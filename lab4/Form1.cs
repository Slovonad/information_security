using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace information_security_lab4_cs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        // Поиск корня большого числа
        private BigInteger Sqrt(BigInteger n)
        {
            if (n == 0) return 0;
            if (n > 0)
            {
                int bitLength = Convert.ToInt32(Math.Ceiling(BigInteger.Log(n, 2)));
                BigInteger root = BigInteger.One << (bitLength / 2);

                while (!isSqrt(n, root))
                {
                    root += n / root;
                    root /= 2;
                }

                return root;
            }

            throw new ArithmeticException("NaN");
        }

        // нужно для поиска корня
        private Boolean isSqrt(BigInteger n, BigInteger root)
        {
            BigInteger lowerBound = root * root;
            BigInteger upperBound = (root + 1) * (root + 1);

            return (n >= lowerBound && n < upperBound);
        }

        // Поиск наибольшего общего делителя 
        private BigInteger NOD(BigInteger a, BigInteger b)
        {
            while (a != b)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }
            return a;
        }

        // Проверка, является ли большое число простым
        private bool isSimple(BigInteger number)
        {
            if (number == 1)
                return false;
            BigInteger i = new BigInteger(2);
            for (i = 2; i <= Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }

        // Слушатель кнопки "зашифровать"
        private void button1_Click(object sender, EventArgs ev)
        {
            if (encryptWarningPQ.Visible || encryptWarningE.Visible || encryptWarningD.Visible)
            {
                MessageBox.Show("Проверьте входные данные!");
            } else
            {
                encryptResultNumbers.Text = "";
                encryptResultText.Text = "";
                BigInteger e = new BigInteger(encryptE.Value);
                BigInteger n = new BigInteger(encryptPQ.Value);
                string message = encryptMessage.Text;
                // Если пользователь ввел текст
                if (encryptRadText.Checked)
                {
                    for (int i = 0; i < message.Length; i++)
                    {
                        BigInteger m = new BigInteger(message[i]);
                        BigInteger answer = BigInteger.Pow(m, (int)e);
                        answer = BigInteger.Remainder(answer, (int)n);
                        encryptResultText.Text += char.ConvertFromUtf32((int)answer);
                        encryptResultNumbers.Text += answer.ToString() + " ";
                    }
                }
                // Если пользователь ввел числа
                else
                {
                    string[] numberStrings = message.Trim().Split(' ');
                    foreach (string numberString in numberStrings)
                    {
                        BigInteger m = BigInteger.Parse(numberString);
                        BigInteger answer = BigInteger.Pow(m, (int)e);
                        answer = BigInteger.Remainder(answer, (int)n);
                        encryptResultText.Text += char.ConvertFromUtf32((int)answer);
                        encryptResultNumbers.Text += answer.ToString() + " ";
                    }
                }
            }
        }

        // Слушатель ввода числа p
        private void encryptP_ValueChanged(object sender, EventArgs e)
        {
            int p = (int)encryptP.Value;
            int q = (int)encryptQ.Value;
            encryptPQ.Value = p * q;
            encryptFi.Value = (p - 1) * (q - 1);
            // Числа неравные и простые
            if (p == q || !isSimple(p) || !isSimple(q))
                encryptWarningPQ.Visible = true;
            else
                encryptWarningPQ.Visible = false;
        }

        // Слушатель ввода числа q
        private void encryptQ_ValueChanged(object sender, EventArgs e)
        {
            int p = (int)encryptP.Value;
            int q = (int)encryptQ.Value;
            encryptPQ.Value = p * q;
            encryptFi.Value = (p - 1) * (q - 1);
            if (p == q || !isSimple(p) || !isSimple(q))
                encryptWarningPQ.Visible = true;
            else
                encryptWarningPQ.Visible = false;
        }

        // Слушатель ввода числа е
        private void encryptE_ValueChanged(object sender, EventArgs even)
        {
            BigInteger e = new BigInteger(encryptE.Value);
            BigInteger fi = new BigInteger(encryptFi.Value);
            // Проверяем, удовлетворяет ли условиям
            if (e >= fi || NOD(e, fi) != 1)
                encryptWarningE.Visible = true;
            else
                encryptWarningE.Visible = false;
        }

        // Слушатель ввода числа d
        private void encryptD_ValueChanged(object sender, EventArgs even)
        {
            BigInteger d = new BigInteger(encryptD.Value);
            BigInteger e = new BigInteger(encryptE.Value);
            int fi = (int)encryptFi.Value;
            encryptWarningPQ.Text = BigInteger.Remainder(d * e, fi).ToString();
            // Проверяем, удовлетворяет ли условиям
            if (BigInteger.Remainder(d*e, fi) != 1)
                encryptWarningD.Visible = true;
            else
                encryptWarningD.Visible = false;
        }

        // слушатель кнопки "расшифровать"
        private void button2_Click(object sender, EventArgs e)
        {
            int d = (int) decryptD.Value;
            int n = (int)(decryptPQ.Value);
            string message = decryptMessage.Text;
            decryptResultNumbers.Text = "";
            decryptResultText.Text = "";
            decryptVariantsText.Visible = false;
            decryptResultNumbers.Visible = true;
            decryptResultText.Visible = true;
            decryptWarning.Visible = false;
            if (decryptRadioText.Checked)
            {
                for (int i = 0; i < message.Length; i++)
                {
                    BigInteger s = new BigInteger(message[i]);
                    BigInteger answer = BigInteger.Pow(s, d);
                    answer = BigInteger.Remainder(answer, n);
                    decryptResultText.Text += char.ConvertFromUtf32((int)answer);
                    decryptResultNumbers.Text += answer.ToString() + " ";
                }
            }
            else
            {
                string[] numberStrings = message.Trim().Split(' ');
                foreach (string numberString in numberStrings)
                {
                    BigInteger s = BigInteger.Parse(numberString);
                    BigInteger answer = BigInteger.Pow(s, d);
                    answer = BigInteger.Remainder(answer, n);
                    decryptResultText.Text += char.ConvertFromUtf32((int)answer);
                    decryptResultNumbers.Text += answer.ToString() + " ";
                }
            }
            // Если исходное сообщение представимо в нескольких вариантах текста
            if (n < Math.Pow(2, 15))
            {
                decryptWarning.Visible = true;
                decryptVariantsText.Visible = true;
                decryptResultText.Visible = false;
                decryptVariantsText.Items.Clear();
                string[] numberStrings = decryptResultNumbers.Text.Trim().Split(' ');
                // Добавляем еще варианты
                for (int i = 0; i < Math.Pow(2, 15); i+=n)
                {
                    string newVariantText = "";
                    foreach (string numberString in numberStrings)
                    {
                        int messageNumber = int.Parse(numberString);
                        newVariantText += char.ConvertFromUtf32(messageNumber + i);
                    }
                    decryptVariantsText.Items.Add(newVariantText);
                }
            }
        }
    }
}
