using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace information_security_lab1_cs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Зашифровать текст
        private string encryptText(string text, int vertical, int horizontal)
        {
            string[,] wordTable = new string[vertical, horizontal];
            int index = 0;

            // Составляем таблицу из слова
            for (int i = 0; i < vertical; i++)
                for (int j = 0; j < horizontal; j++)
                    wordTable[i, j] = (index < text.Length) ? text[index++].ToString() : " ";

            // Получаем слово из таблицы
            string secretMessage = "";
            for (int j = 0; j < horizontal; j++)
                for (int i = 0; i < vertical; i++)
                    secretMessage += wordTable[i, j];

            return secretMessage;
        }

        // расшифровать текст
        private static string decryptText(string text, int vertical, int horizontal)
        {
            int length = text.Length;
            string[,] wordTable = new string[vertical, horizontal];
            int wordIndex = 0;

            // Составляем таблицу из слова
            for (int j = 0; j < horizontal; j++)
                for (int i = 0; i < vertical; i++)
                    wordTable[i, j] = (wordIndex < length) ? text[wordIndex++].ToString() : "";

            // Получаем слово из таблицы
            string decrypted = "";
            for (int i = 0; i < vertical; i++)
                for (int j = 0; j < horizontal; j++)
                    decrypted += wordTable[i, j];

            return decrypted;
        }


        // Функция возвращает массив из слов текста, которые есть в русском словаре
        private static List<string> getListOfWordsFromRussianDictionary(string text)
        {

            List<string> result = new List<string>();
            // Паттерн, чтобы оставить только буквы русского языка в тексте
            string pattern = "[^а-яА-Я ]";
            // Все остальные буквы и символы заменяем на пустую строку
            var clearText = new List<string>(Regex.Replace(text, pattern, "").Split(" "));
            // Регистрация провайдера кодировок для поддержки дополнительных кодировок
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            // Меняем кодировку (чтобы файл читался адекватно)
            var sr = new System.IO.StreamReader("ru_dictionary.txt", encoding: Encoding.GetEncoding(1251));
            // Пробегаемся по файлу
            while (sr.Peek() >= 0)
            {
                // Читаем новую строку
                var newLine = sr.ReadLine().Trim();
                // Ищем в переданном тексте итерируемое слово
                var foundWords = clearText.FindAll(e => e.ToLower() == newLine.ToLower());
                // Добавляем сразу несколько слов (если в тексте есть повторы)
                result.AddRange(foundWords);
            }
            return result;
        }

        // Функция принимает на вход массив из слов и возвращает суммарное кол-во букв в этих словах
        private static int wordsLettersCount(List<string> wordsList)
        {
            int counter = 0;
            foreach (var word in wordsList)
                counter += word.Length;
            return counter;
        }

        // Взлом шифра
        private static string hackText(string text)
        {
            // Взломанное сообщение
            string result = "";
            // Проверенные и добавленные варианты расшифровки
            // Вариант расшифровки: количество букв из слов русского словаря
            Dictionary<string, int> variants = new Dictionary<string, int>();
            string pattern = "[^а-яА-Я]";
            for (int i = 0; i < text.Length; i++)
                for (int j = 0; j < text.Length; j++)
                    if (text.Length <= i * j)
                    {
                        // Перебираем все варианты дешифровки
                        string decryptedText = decryptText(text, i, j);
                        // Следим, чтобы такого варианта еще не было в словаре
                        if (!variants.ContainsKey(decryptedText))
                        {
                            // Получаем все осмысленные слова из текущей расшифровки
                            var wordsList = getListOfWordsFromRussianDictionary(decryptedText);
                            // Убираем все мусорные символы (все, кроме кириллицы) 
                            var clearText = Regex.Replace(decryptedText, pattern, "");
                            var lettersCount = wordsLettersCount(wordsList);
                            // Если все буквы из расшифрованных слов покрывают все буквы из текста, то сразу возвращаем
                            if (clearText.Length == lettersCount)
                                return decryptedText;
                            variants.Add(decryptedText, lettersCount);
                        }
                    }
            int maxWordCount = 0;
            // Ищем вариант с максимальным покрытием букв
            foreach (KeyValuePair<string, int> variant in variants)
                if (variant.Value > maxWordCount)
                {
                    result = variant.Key;
                    maxWordCount = variant.Value;
                }
            // Обрезаем пробелы с начала и с конца
            return result.Trim();
        }

        // Шифрование
        private void button1_Click(object sender, EventArgs e)
        {
            string text = encrypt_text.Text;
            int verticalLetters = (int)encrypt_vertical_letters.Value;
            int horizontalLetters = (int)encrypt_horizontal_letters.Value;
            if (text.Length > verticalLetters * horizontalLetters)
            {
                MessageBox.Show("Текст не может быть зашифрован с учетом введенных данных");
            }
            else
            {
                encrypt_result.Text = encryptText(text, verticalLetters, horizontalLetters);
            }
        }

        // Расшифровка
        private void button2_Click(object sender, EventArgs e)
        {
            string text = decrypt_text.Text;
            int verticalLetters = (int)decrypt_vertical_letters.Value;
            int horizontalLetters = (int)decrypt_horizontal_letters.Value;
            if (text.Length > verticalLetters * horizontalLetters)
            {
                MessageBox.Show("Текст не может быть расшифрован с учетом введенных данных");
            }
            else
            {
                decrypt_result.Text = decryptText(text, verticalLetters, horizontalLetters);
            }
        }


        // Взлом
        private void button3_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            string text = hack_text.Text;
            hack_result.Text = hackText(text);
            Cursor.Current = Cursors.Default;
        }
    }
}
