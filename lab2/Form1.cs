using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace information_security_lab2_cs
{
    public partial class Form1 : Form
    {
        static string russianAlphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЬЫЪЭЮЯ";
        public Form1()
        {
            InitializeComponent();
        }

        // Функция построения нового алфавита на основе сдвига
        private static string BuildNewAlphabetFromStartIndex(int startIndex)
        {
            string newAlphabet = "";
            // Заполняем от startIndex до конца
            for (int i = 0; i + startIndex < russianAlphabet.Length; i++)
                    newAlphabet += russianAlphabet[i + startIndex];
            // Заполняем сначала до startIndex
            for (int i = 0; i < startIndex; i++)
                newAlphabet += russianAlphabet[i];
            return newAlphabet;
        }

        private static string EncryptText(string text, string secretWord)
        {
            StringBuilder encryptedText = new StringBuilder();
            int secretWordIterator = 0;
            for (int i = 0; i < text.Length; i++)
            {
                // Если символ буква и она русская
                if (char.IsLetter(text[i]) && russianAlphabet.Contains(text[i].ToString().ToUpper()))
                {
                    int letterPosition = russianAlphabet.IndexOf(char.ToUpper(text[i]));
                    string newAlphabet = BuildNewAlphabetFromStartIndex(russianAlphabet.IndexOf(char.ToUpper(secretWord[secretWordIterator])));
                    // Преобразуем кейс в оригинальный
                    if (char.IsUpper(text[i]))
                    {
                        encryptedText.Append(newAlphabet[letterPosition]);
                    }
                    else
                    {
                        encryptedText.Append(char.ToLower(newAlphabet[letterPosition]));
                    }
                    secretWordIterator++;
                    if (secretWordIterator >= secretWord.Length)
                    {
                        secretWordIterator = 0;
                    }
                }
                else
                {
                    encryptedText.Append(text[i]);
                }
            }
            return encryptedText.ToString();
        }

        static string DecryptText(string encryptedText, string secretWord)
        {
            StringBuilder decryptedText = new StringBuilder();
            int secretWordIterator = 0;

            for (int i = 0; i < encryptedText.Length; i++)
            {
                if (char.IsLetter(encryptedText[i]) && russianAlphabet.Contains(encryptedText[i].ToString().ToUpper()))
                {
                    // Строим новый алфавит на основе буквы из ключа
                    string newAlphabet = BuildNewAlphabetFromStartIndex(russianAlphabet.IndexOf(char.ToUpper(secretWord[secretWordIterator])));
                    int letterPosition = newAlphabet.IndexOf(encryptedText[i].ToString().ToUpper());
                    if (char.IsUpper(encryptedText[i]))
                    {
                        decryptedText.Append(russianAlphabet[letterPosition]);
                    }
                    else
                    {
                        decryptedText.Append(char.ToLower(russianAlphabet[letterPosition]));
                    }
                    secretWordIterator++;
                    if (secretWordIterator >= secretWord.Length)
                    {
                        secretWordIterator = 0;
                    }
                }
                else
                {
                    decryptedText.Append(encryptedText[i]);
                }
            }

            return decryptedText.ToString();
        }

        // Кнопка "Зашифровать"
        private void button1_Click(object sender, EventArgs e)
        {
            string text = encryptionText.Text;
            string secretWord = encryptionKey.Text;
            encryptionResult.Text = EncryptText(text, secretWord);
        }

        // Кнопка "Расшифровать"
        private void button2_Click(object sender, EventArgs e)
        {
            string text = decryptText.Text;
            string secretWord = decryptKey.Text;
            decryptResult.Text = DecryptText(text, secretWord);
        }
    }
}
