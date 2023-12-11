
namespace information_security_lab1_cs
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
            System.Windows.Forms.Button button3;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.encrypt_horizontal_letters = new System.Windows.Forms.NumericUpDown();
            this.encrypt_vertical_letters = new System.Windows.Forms.NumericUpDown();
            this.encrypt_result = new System.Windows.Forms.TextBox();
            this.encrypt_text_btn = new System.Windows.Forms.Button();
            this.encrypt_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.decrypt_horizontal_letters = new System.Windows.Forms.NumericUpDown();
            this.decrypt_vertical_letters = new System.Windows.Forms.NumericUpDown();
            this.decrypt_result = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.decrypt_text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.hack_result = new System.Windows.Forms.TextBox();
            this.hack_text = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            button3 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.encrypt_horizontal_letters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.encrypt_vertical_letters)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.decrypt_horizontal_letters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.decrypt_vertical_letters)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(126, 202);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(120, 23);
            button3.TabIndex = 16;
            button3.Text = "Взломать";
            button3.UseVisualStyleBackColor = true;
            button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(706, 512);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.encrypt_horizontal_letters);
            this.tabPage1.Controls.Add(this.encrypt_vertical_letters);
            this.tabPage1.Controls.Add(this.encrypt_result);
            this.tabPage1.Controls.Add(this.encrypt_text_btn);
            this.tabPage1.Controls.Add(this.encrypt_text);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(698, 484);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Шифрование";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(91, 355);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "Закодированное сообщение:";
            // 
            // encrypt_horizontal_letters
            // 
            this.encrypt_horizontal_letters.Location = new System.Drawing.Point(6, 249);
            this.encrypt_horizontal_letters.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.encrypt_horizontal_letters.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.encrypt_horizontal_letters.Name = "encrypt_horizontal_letters";
            this.encrypt_horizontal_letters.Size = new System.Drawing.Size(188, 23);
            this.encrypt_horizontal_letters.TabIndex = 9;
            this.encrypt_horizontal_letters.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // encrypt_vertical_letters
            // 
            this.encrypt_vertical_letters.Location = new System.Drawing.Point(6, 168);
            this.encrypt_vertical_letters.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.encrypt_vertical_letters.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.encrypt_vertical_letters.Name = "encrypt_vertical_letters";
            this.encrypt_vertical_letters.Size = new System.Drawing.Size(188, 23);
            this.encrypt_vertical_letters.TabIndex = 8;
            this.encrypt_vertical_letters.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // encrypt_result
            // 
            this.encrypt_result.Location = new System.Drawing.Point(6, 385);
            this.encrypt_result.Name = "encrypt_result";
            this.encrypt_result.Size = new System.Drawing.Size(352, 23);
            this.encrypt_result.TabIndex = 7;
            // 
            // encrypt_text_btn
            // 
            this.encrypt_text_btn.Location = new System.Drawing.Point(103, 307);
            this.encrypt_text_btn.Name = "encrypt_text_btn";
            this.encrypt_text_btn.Size = new System.Drawing.Size(120, 23);
            this.encrypt_text_btn.TabIndex = 6;
            this.encrypt_text_btn.Text = "Зашифровать";
            this.encrypt_text_btn.UseVisualStyleBackColor = true;
            this.encrypt_text_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // encrypt_text
            // 
            this.encrypt_text.Location = new System.Drawing.Point(6, 79);
            this.encrypt_text.Name = "encrypt_text";
            this.encrypt_text.Size = new System.Drawing.Size(217, 23);
            this.encrypt_text.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Количество букв (по горизонтали):\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Количество букв (по вертикали):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите сообщения для кодирования:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.decrypt_horizontal_letters);
            this.tabPage2.Controls.Add(this.decrypt_vertical_letters);
            this.tabPage2.Controls.Add(this.decrypt_result);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.decrypt_text);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(698, 484);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Дешифрование";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(116, 354);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "Исходное сообщение:";
            // 
            // decrypt_horizontal_letters
            // 
            this.decrypt_horizontal_letters.Location = new System.Drawing.Point(6, 252);
            this.decrypt_horizontal_letters.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.decrypt_horizontal_letters.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.decrypt_horizontal_letters.Name = "decrypt_horizontal_letters";
            this.decrypt_horizontal_letters.Size = new System.Drawing.Size(120, 23);
            this.decrypt_horizontal_letters.TabIndex = 17;
            this.decrypt_horizontal_letters.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // decrypt_vertical_letters
            // 
            this.decrypt_vertical_letters.Location = new System.Drawing.Point(6, 180);
            this.decrypt_vertical_letters.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.decrypt_vertical_letters.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.decrypt_vertical_letters.Name = "decrypt_vertical_letters";
            this.decrypt_vertical_letters.Size = new System.Drawing.Size(120, 23);
            this.decrypt_vertical_letters.TabIndex = 16;
            this.decrypt_vertical_letters.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // decrypt_result
            // 
            this.decrypt_result.Location = new System.Drawing.Point(6, 387);
            this.decrypt_result.Name = "decrypt_result";
            this.decrypt_result.Size = new System.Drawing.Size(352, 23);
            this.decrypt_result.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(116, 308);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Расшифровать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // decrypt_text
            // 
            this.decrypt_text.Location = new System.Drawing.Point(6, 100);
            this.decrypt_text.Name = "decrypt_text";
            this.decrypt_text.Size = new System.Drawing.Size(170, 23);
            this.decrypt_text.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Количество букв (по горизонтали):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Количество букв (по вертикали):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Зашифрованное сообщение:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.hack_result);
            this.tabPage3.Controls.Add(button3);
            this.tabPage3.Controls.Add(this.hack_text);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(698, 484);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Взлом";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(115, 260);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 15);
            this.label10.TabIndex = 18;
            this.label10.Text = "Исходное сообщение:";
            // 
            // hack_result
            // 
            this.hack_result.Location = new System.Drawing.Point(6, 294);
            this.hack_result.Name = "hack_result";
            this.hack_result.Size = new System.Drawing.Size(352, 23);
            this.hack_result.TabIndex = 17;
            // 
            // hack_text
            // 
            this.hack_text.Location = new System.Drawing.Point(8, 129);
            this.hack_text.Name = "hack_text";
            this.hack_text.Size = new System.Drawing.Size(168, 23);
            this.hack_text.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Зашифрованное сообщение:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 536);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Лаб 1. Брусочный шифр";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.encrypt_horizontal_letters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.encrypt_vertical_letters)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.decrypt_horizontal_letters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.decrypt_vertical_letters)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.NumericUpDown encrypt_horizontal_letters;
        private System.Windows.Forms.NumericUpDown encrypt_vertical_letters;
        private System.Windows.Forms.TextBox encrypt_result;
        private System.Windows.Forms.Button encrypt_text_btn;
        private System.Windows.Forms.TextBox encrypt_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.NumericUpDown decrypt_horizontal_letters;
        private System.Windows.Forms.NumericUpDown decrypt_vertical_letters;
        private System.Windows.Forms.TextBox decrypt_result;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox decrypt_text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox hack_result;
        private System.Windows.Forms.TextBox hack_text;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

