
namespace information_security_lab2_cs
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.encryptionKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.encryptionResult = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.encryptionText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.decryptKey = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.decryptResult = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.decryptText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(343, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.encryptionKey);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.encryptionResult);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.encryptionText);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(335, 398);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Зашифровать текст";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Зашифрованный текст:";
            // 
            // encryptionKey
            // 
            this.encryptionKey.Location = new System.Drawing.Point(75, 176);
            this.encryptionKey.Name = "encryptionKey";
            this.encryptionKey.Size = new System.Drawing.Size(173, 23);
            this.encryptionKey.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Введите ключ:";
            // 
            // encryptionResult
            // 
            this.encryptionResult.Location = new System.Drawing.Point(75, 325);
            this.encryptionResult.Name = "encryptionResult";
            this.encryptionResult.Size = new System.Drawing.Size(173, 23);
            this.encryptionResult.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(109, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Зашифровать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // encryptionText
            // 
            this.encryptionText.Location = new System.Drawing.Point(75, 86);
            this.encryptionText.Name = "encryptionText";
            this.encryptionText.Size = new System.Drawing.Size(173, 23);
            this.encryptionText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите текст, который нужно зашифровать:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.decryptKey);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.decryptResult);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.decryptText);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(335, 398);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Расшифровать текст";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Оригинал текста:";
            // 
            // decryptKey
            // 
            this.decryptKey.Location = new System.Drawing.Point(74, 181);
            this.decryptKey.Name = "decryptKey";
            this.decryptKey.Size = new System.Drawing.Size(173, 23);
            this.decryptKey.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(121, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Введите ключ:";
            // 
            // decryptResult
            // 
            this.decryptResult.Location = new System.Drawing.Point(74, 330);
            this.decryptResult.Name = "decryptResult";
            this.decryptResult.Size = new System.Drawing.Size(173, 23);
            this.decryptResult.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(108, 240);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Расшифровать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // decryptText
            // 
            this.decryptText.Location = new System.Drawing.Point(74, 91);
            this.decryptText.Name = "decryptText";
            this.decryptText.Size = new System.Drawing.Size(173, 23);
            this.decryptText.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(263, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Введите текст, который нужно расшифровать:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Лаб2. Вижинер";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox encryptionResult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox encryptionText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox encryptionKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox decryptKey;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox decryptResult;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox decryptText;
    }
}

