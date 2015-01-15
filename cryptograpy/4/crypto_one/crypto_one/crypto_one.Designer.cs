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
            this.tb_key = new System.Windows.Forms.TextBox();
            this.b_crypt = new System.Windows.Forms.Button();
            this.rtb_descr = new System.Windows.Forms.RichTextBox();
            this.rb_en = new System.Windows.Forms.RadioButton();
            this.rb_ru = new System.Windows.Forms.RadioButton();
            this.rb_uk = new System.Windows.Forms.RadioButton();
            this.rtb_lang = new System.Windows.Forms.RichTextBox();
            this.b_lang = new System.Windows.Forms.Button();
            this.b_cancel = new System.Windows.Forms.Button();
            this.tb_card = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.b_decrypt = new System.Windows.Forms.Button();
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
            this.label5.Location = new System.Drawing.Point(15, 68);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "binary key :";
            // 
            // tb_key
            // 
            this.tb_key.Location = new System.Drawing.Point(114, 66);
            this.tb_key.Name = "tb_key";
            this.tb_key.Size = new System.Drawing.Size(348, 26);
            this.tb_key.TabIndex = 9;
            // 
            // b_crypt
            // 
            this.b_crypt.BackColor = System.Drawing.Color.LightSeaGreen;
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
            this.rb_en.Location = new System.Drawing.Point(332, 21);
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
            this.rb_ru.Location = new System.Drawing.Point(247, 21);
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
            this.rb_uk.Location = new System.Drawing.Point(159, 21);
            this.rb_uk.Name = "rb_uk";
            this.rb_uk.Size = new System.Drawing.Size(53, 24);
            this.rb_uk.TabIndex = 17;
            this.rb_uk.TabStop = true;
            this.rb_uk.Text = "UK";
            this.rb_uk.UseVisualStyleBackColor = true;
            this.rb_uk.CheckedChanged += new System.EventHandler(this.rb_lang_CheckedChanged);
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
            this.b_lang.BackColor = System.Drawing.Color.LightSeaGreen;
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
            this.b_cancel.BackColor = System.Drawing.Color.LightSeaGreen;
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
            this.b_decrypt.BackColor = System.Drawing.Color.LightSeaGreen;
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
            // crypto_one
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(985, 498);
            this.Controls.Add(this.tb_key);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.b_decrypt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_card);
            this.Controls.Add(this.b_cancel);
            this.Controls.Add(this.b_lang);
            this.Controls.Add(this.rtb_lang);
            this.Controls.Add(this.rb_uk);
            this.Controls.Add(this.rb_ru);
            this.Controls.Add(this.rb_en);
            this.Controls.Add(this.rtb_descr);
            this.Controls.Add(this.b_crypt);
            this.Controls.Add(this.rtb_output);
            this.Controls.Add(this.rtb_input);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "crypto_one";
            this.Text = "Binary";
            this.Load += new System.EventHandler(this.crypto_one_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtb_input;
        private System.Windows.Forms.RichTextBox rtb_output;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_key;
        private System.Windows.Forms.Button b_crypt;
        private System.Windows.Forms.RichTextBox rtb_descr;
        private System.Windows.Forms.RadioButton rb_en;
        private System.Windows.Forms.RadioButton rb_ru;
        private System.Windows.Forms.RadioButton rb_uk;
        private System.Windows.Forms.RichTextBox rtb_lang;
        private System.Windows.Forms.Button b_lang;
        private System.Windows.Forms.Button b_cancel;
        private System.Windows.Forms.TextBox tb_card;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_decrypt;
    }
}

