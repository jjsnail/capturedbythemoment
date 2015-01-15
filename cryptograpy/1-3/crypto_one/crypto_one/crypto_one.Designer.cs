namespace crypto_one
{
    partial class crypto_one
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtb_input = new System.Windows.Forms.RichTextBox();
            this.rtb_output = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_m = new System.Windows.Forms.TextBox();
            this.b_crypt = new System.Windows.Forms.Button();
            this.cb_method = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rtb_descr = new System.Windows.Forms.RichTextBox();
            this.rb_en = new System.Windows.Forms.RadioButton();
            this.rb_ru = new System.Windows.Forms.RadioButton();
            this.rb_uk = new System.Windows.Forms.RadioButton();
            this.tb_a = new System.Windows.Forms.TextBox();
            this.tb_b = new System.Windows.Forms.TextBox();
            this.l_a = new System.Windows.Forms.Label();
            this.l_b = new System.Windows.Forms.Label();
            this.p_two = new System.Windows.Forms.Panel();
            this.p_three = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_k = new System.Windows.Forms.TextBox();
            this.tb_key_word = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rtb_lang = new System.Windows.Forms.RichTextBox();
            this.b_lang = new System.Windows.Forms.Button();
            this.b_cancel = new System.Windows.Forms.Button();
            this.tb_card = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.b_decrypt = new System.Windows.Forms.Button();
            this.p_one = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_mod = new System.Windows.Forms.TextBox();
            this.p_two.SuspendLayout();
            this.p_three.SuspendLayout();
            this.p_one.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 266);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data to encrypt :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 266);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Data to decrypt :";
            // 
            // rtb_input
            // 
            this.rtb_input.Location = new System.Drawing.Point(15, 288);
            this.rtb_input.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rtb_input.Name = "rtb_input";
            this.rtb_input.Size = new System.Drawing.Size(254, 152);
            this.rtb_input.TabIndex = 4;
            this.rtb_input.Text = "";
            // 
            // rtb_output
            // 
            this.rtb_output.Location = new System.Drawing.Point(277, 289);
            this.rtb_output.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rtb_output.Name = "rtb_output";
            this.rtb_output.Size = new System.Drawing.Size(266, 151);
            this.rtb_output.TabIndex = 5;
            this.rtb_output.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 5);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "m :";
            // 
            // tb_m
            // 
            this.tb_m.Location = new System.Drawing.Point(133, 3);
            this.tb_m.Name = "tb_m";
            this.tb_m.Size = new System.Drawing.Size(39, 26);
            this.tb_m.TabIndex = 9;
            // 
            // b_crypt
            // 
            this.b_crypt.BackColor = System.Drawing.Color.Green;
            this.b_crypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_crypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_crypt.ForeColor = System.Drawing.Color.White;
            this.b_crypt.Location = new System.Drawing.Point(15, 446);
            this.b_crypt.Name = "b_crypt";
            this.b_crypt.Size = new System.Drawing.Size(254, 43);
            this.b_crypt.TabIndex = 11;
            this.b_crypt.Text = "ENCRYPT";
            this.b_crypt.UseVisualStyleBackColor = false;
            this.b_crypt.Click += new System.EventHandler(this.b_crypt_Click);
            // 
            // cb_method
            // 
            this.cb_method.FormattingEnabled = true;
            this.cb_method.Location = new System.Drawing.Point(293, 15);
            this.cb_method.Name = "cb_method";
            this.cb_method.Size = new System.Drawing.Size(171, 28);
            this.cb_method.TabIndex = 12;
            this.cb_method.SelectedIndexChanged += new System.EventHandler(this.cb_method_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Method :";
            // 
            // rtb_descr
            // 
            this.rtb_descr.Location = new System.Drawing.Point(18, 110);
            this.rtb_descr.Name = "rtb_descr";
            this.rtb_descr.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtb_descr.Size = new System.Drawing.Size(525, 153);
            this.rtb_descr.TabIndex = 14;
            this.rtb_descr.Text = "";
            // 
            // rb_en
            // 
            this.rb_en.AutoSize = true;
            this.rb_en.Location = new System.Drawing.Point(501, 77);
            this.rb_en.Name = "rb_en";
            this.rb_en.Size = new System.Drawing.Size(53, 24);
            this.rb_en.TabIndex = 15;
            this.rb_en.TabStop = true;
            this.rb_en.Text = "EN";
            this.rb_en.UseVisualStyleBackColor = true;
            this.rb_en.CheckedChanged += new System.EventHandler(this.rb_lang_CheckedChanged);
            // 
            // rb_ru
            // 
            this.rb_ru.AutoSize = true;
            this.rb_ru.Location = new System.Drawing.Point(501, 47);
            this.rb_ru.Name = "rb_ru";
            this.rb_ru.Size = new System.Drawing.Size(54, 24);
            this.rb_ru.TabIndex = 16;
            this.rb_ru.TabStop = true;
            this.rb_ru.Text = "RU";
            this.rb_ru.UseVisualStyleBackColor = true;
            this.rb_ru.CheckedChanged += new System.EventHandler(this.rb_lang_CheckedChanged);
            // 
            // rb_uk
            // 
            this.rb_uk.AutoSize = true;
            this.rb_uk.Location = new System.Drawing.Point(501, 16);
            this.rb_uk.Name = "rb_uk";
            this.rb_uk.Size = new System.Drawing.Size(53, 24);
            this.rb_uk.TabIndex = 17;
            this.rb_uk.TabStop = true;
            this.rb_uk.Text = "UK";
            this.rb_uk.UseVisualStyleBackColor = true;
            this.rb_uk.CheckedChanged += new System.EventHandler(this.rb_lang_CheckedChanged);
            // 
            // tb_a
            // 
            this.tb_a.Location = new System.Drawing.Point(30, 9);
            this.tb_a.Name = "tb_a";
            this.tb_a.Size = new System.Drawing.Size(39, 26);
            this.tb_a.TabIndex = 18;
            // 
            // tb_b
            // 
            this.tb_b.Location = new System.Drawing.Point(104, 8);
            this.tb_b.Name = "tb_b";
            this.tb_b.Size = new System.Drawing.Size(38, 26);
            this.tb_b.TabIndex = 19;
            // 
            // l_a
            // 
            this.l_a.AutoSize = true;
            this.l_a.Location = new System.Drawing.Point(4, 11);
            this.l_a.Name = "l_a";
            this.l_a.Size = new System.Drawing.Size(28, 20);
            this.l_a.TabIndex = 20;
            this.l_a.Text = "a :";
            // 
            // l_b
            // 
            this.l_b.AutoSize = true;
            this.l_b.Location = new System.Drawing.Point(73, 11);
            this.l_b.Name = "l_b";
            this.l_b.Size = new System.Drawing.Size(28, 20);
            this.l_b.TabIndex = 21;
            this.l_b.Text = "b :";
            // 
            // p_two
            // 
            this.p_two.Controls.Add(this.tb_b);
            this.p_two.Controls.Add(this.l_b);
            this.p_two.Controls.Add(this.tb_a);
            this.p_two.Controls.Add(this.l_a);
            this.p_two.Location = new System.Drawing.Point(6, 52);
            this.p_two.Name = "p_two";
            this.p_two.Size = new System.Drawing.Size(151, 44);
            this.p_two.TabIndex = 22;
            this.p_two.Visible = false;
            // 
            // p_three
            // 
            this.p_three.Controls.Add(this.label7);
            this.p_three.Controls.Add(this.tb_k);
            this.p_three.Controls.Add(this.tb_key_word);
            this.p_three.Controls.Add(this.label6);
            this.p_three.Location = new System.Drawing.Point(163, 52);
            this.p_three.Name = "p_three";
            this.p_three.Size = new System.Drawing.Size(334, 44);
            this.p_three.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "k :";
            // 
            // tb_k
            // 
            this.tb_k.Location = new System.Drawing.Point(30, 8);
            this.tb_k.Name = "tb_k";
            this.tb_k.Size = new System.Drawing.Size(42, 26);
            this.tb_k.TabIndex = 23;
            // 
            // tb_key_word
            // 
            this.tb_key_word.Location = new System.Drawing.Point(155, 8);
            this.tb_key_word.Name = "tb_key_word";
            this.tb_key_word.Size = new System.Drawing.Size(168, 26);
            this.tb_key_word.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "keyword :";
            // 
            // rtb_lang
            // 
            this.rtb_lang.Location = new System.Drawing.Point(560, 60);
            this.rtb_lang.Name = "rtb_lang";
            this.rtb_lang.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtb_lang.Size = new System.Drawing.Size(413, 380);
            this.rtb_lang.TabIndex = 24;
            this.rtb_lang.Text = "";
            this.rtb_lang.TextChanged += new System.EventHandler(this.b_lang_TextChanged);
            this.rtb_lang.Enter += new System.EventHandler(this.rtb_lang_Enter);
            // 
            // b_lang
            // 
            this.b_lang.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.b_lang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_lang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_lang.ForeColor = System.Drawing.Color.White;
            this.b_lang.Location = new System.Drawing.Point(560, 12);
            this.b_lang.Name = "b_lang";
            this.b_lang.Size = new System.Drawing.Size(204, 43);
            this.b_lang.TabIndex = 25;
            this.b_lang.Text = "SAVE";
            this.b_lang.UseVisualStyleBackColor = false;
            this.b_lang.Visible = false;
            this.b_lang.Click += new System.EventHandler(this.b_lang_Click);
            // 
            // b_cancel
            // 
            this.b_cancel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.b_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_cancel.ForeColor = System.Drawing.Color.White;
            this.b_cancel.Location = new System.Drawing.Point(770, 12);
            this.b_cancel.Name = "b_cancel";
            this.b_cancel.Size = new System.Drawing.Size(203, 43);
            this.b_cancel.TabIndex = 26;
            this.b_cancel.Text = "CANCEL";
            this.b_cancel.UseVisualStyleBackColor = false;
            this.b_cancel.Visible = false;
            this.b_cancel.Click += new System.EventHandler(this.b_cancel_Click);
            // 
            // tb_card
            // 
            this.tb_card.Enabled = false;
            this.tb_card.Location = new System.Drawing.Point(660, 457);
            this.tb_card.Name = "tb_card";
            this.tb_card.ReadOnly = true;
            this.tb_card.Size = new System.Drawing.Size(104, 26);
            this.tb_card.TabIndex = 27;
            this.tb_card.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(556, 460);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Cardinality :";
            // 
            // b_decrypt
            // 
            this.b_decrypt.BackColor = System.Drawing.Color.Green;
            this.b_decrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_decrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_decrypt.ForeColor = System.Drawing.Color.White;
            this.b_decrypt.Location = new System.Drawing.Point(277, 446);
            this.b_decrypt.Name = "b_decrypt";
            this.b_decrypt.Size = new System.Drawing.Size(266, 43);
            this.b_decrypt.TabIndex = 29;
            this.b_decrypt.Text = "DECRYPT";
            this.b_decrypt.UseVisualStyleBackColor = false;
            this.b_decrypt.Click += new System.EventHandler(this.b_decrypt_Click);
            // 
            // p_one
            // 
            this.p_one.Controls.Add(this.tb_mod);
            this.p_one.Controls.Add(this.label8);
            this.p_one.Controls.Add(this.label5);
            this.p_one.Controls.Add(this.tb_m);
            this.p_one.Location = new System.Drawing.Point(6, 15);
            this.p_one.Name = "p_one";
            this.p_one.Size = new System.Drawing.Size(187, 32);
            this.p_one.TabIndex = 30;
            this.p_one.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 6);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 31;
            this.label8.Text = "mod :";
            // 
            // tb_mod
            // 
            this.tb_mod.Location = new System.Drawing.Point(55, 3);
            this.tb_mod.Name = "tb_mod";
            this.tb_mod.Size = new System.Drawing.Size(39, 26);
            this.tb_mod.TabIndex = 31;
            // 
            // crypto_one
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(985, 498);
            this.Controls.Add(this.p_one);
            this.Controls.Add(this.b_decrypt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_card);
            this.Controls.Add(this.b_cancel);
            this.Controls.Add(this.b_lang);
            this.Controls.Add(this.rtb_lang);
            this.Controls.Add(this.p_three);
            this.Controls.Add(this.p_two);
            this.Controls.Add(this.rb_uk);
            this.Controls.Add(this.rb_ru);
            this.Controls.Add(this.rb_en);
            this.Controls.Add(this.rtb_descr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_method);
            this.Controls.Add(this.b_crypt);
            this.Controls.Add(this.rtb_output);
            this.Controls.Add(this.rtb_input);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "crypto_one";
            this.Text = "Cesar";
            this.Load += new System.EventHandler(this.crypto_one_Load);
            this.p_two.ResumeLayout(false);
            this.p_two.PerformLayout();
            this.p_three.ResumeLayout(false);
            this.p_three.PerformLayout();
            this.p_one.ResumeLayout(false);
            this.p_one.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtb_input;
        private System.Windows.Forms.RichTextBox rtb_output;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_m;
        private System.Windows.Forms.Button b_crypt;
        private System.Windows.Forms.ComboBox cb_method;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtb_descr;
        private System.Windows.Forms.RadioButton rb_en;
        private System.Windows.Forms.RadioButton rb_ru;
        private System.Windows.Forms.RadioButton rb_uk;
        private System.Windows.Forms.TextBox tb_a;
        private System.Windows.Forms.TextBox tb_b;
        private System.Windows.Forms.Label l_a;
        private System.Windows.Forms.Label l_b;
        private System.Windows.Forms.Panel p_two;
        private System.Windows.Forms.Panel p_three;
        private System.Windows.Forms.TextBox tb_key_word;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtb_lang;
        private System.Windows.Forms.Button b_lang;
        private System.Windows.Forms.Button b_cancel;
        private System.Windows.Forms.TextBox tb_card;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_decrypt;
        private System.Windows.Forms.Panel p_one;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_k;
        private System.Windows.Forms.TextBox tb_mod;
        private System.Windows.Forms.Label label8;
    }
}

