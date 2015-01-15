namespace Tests
{
    partial class Form1
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
            this.tb_in = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rtb_lang = new System.Windows.Forms.RichTextBox();
            this.rb_uk = new System.Windows.Forms.RadioButton();
            this.rb_ru = new System.Windows.Forms.RadioButton();
            this.rb_en = new System.Windows.Forms.RadioButton();
            this.tb_bin = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.s_label = new System.Windows.Forms.ToolStripStatusLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_delta = new System.Windows.Forms.TextBox();
            this.tb_ksi_mono = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_ksi_dual = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_ksi_poker = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_ksi_ser = new System.Windows.Forms.TextBox();
            this.tb_poker = new System.Windows.Forms.TextBox();
            this.tb_dual = new System.Windows.Forms.TextBox();
            this.tb_ser = new System.Windows.Forms.TextBox();
            this.tb_mono = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_in
            // 
            this.tb_in.Location = new System.Drawing.Point(77, 115);
            this.tb_in.Name = "tb_in";
            this.tb_in.Size = new System.Drawing.Size(354, 22);
            this.tb_in.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(419, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "FORM SEQUENCE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "TEXT :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "BIN :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = ": SERIES";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(225, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = ": DUALBIT SERIES";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(225, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = ": MONOBIT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(225, 384);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = ": POKER\'S";
            // 
            // rtb_lang
            // 
            this.rtb_lang.Location = new System.Drawing.Point(77, 8);
            this.rtb_lang.Name = "rtb_lang";
            this.rtb_lang.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtb_lang.Size = new System.Drawing.Size(354, 101);
            this.rtb_lang.TabIndex = 48;
            this.rtb_lang.Text = "";
            // 
            // rb_uk
            // 
            this.rb_uk.AutoSize = true;
            this.rb_uk.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_uk.Location = new System.Drawing.Point(21, 18);
            this.rb_uk.Name = "rb_uk";
            this.rb_uk.Size = new System.Drawing.Size(48, 21);
            this.rb_uk.TabIndex = 47;
            this.rb_uk.TabStop = true;
            this.rb_uk.Text = "UK";
            this.rb_uk.UseVisualStyleBackColor = true;
            this.rb_uk.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rb_ru
            // 
            this.rb_ru.AutoSize = true;
            this.rb_ru.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_ru.Location = new System.Drawing.Point(19, 49);
            this.rb_ru.Name = "rb_ru";
            this.rb_ru.Size = new System.Drawing.Size(49, 21);
            this.rb_ru.TabIndex = 46;
            this.rb_ru.TabStop = true;
            this.rb_ru.Text = "RU";
            this.rb_ru.UseVisualStyleBackColor = true;
            this.rb_ru.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rb_en
            // 
            this.rb_en.AutoSize = true;
            this.rb_en.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_en.Location = new System.Drawing.Point(20, 81);
            this.rb_en.Name = "rb_en";
            this.rb_en.Size = new System.Drawing.Size(48, 21);
            this.rb_en.TabIndex = 45;
            this.rb_en.TabStop = true;
            this.rb_en.Text = "EN";
            this.rb_en.UseVisualStyleBackColor = true;
            this.rb_en.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // tb_bin
            // 
            this.tb_bin.Location = new System.Drawing.Point(77, 172);
            this.tb_bin.Name = "tb_bin";
            this.tb_bin.Size = new System.Drawing.Size(353, 82);
            this.tb_bin.TabIndex = 50;
            this.tb_bin.Text = "";
            this.tb_bin.TextChanged += new System.EventHandler(this.tb_bin_TextChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.s_label});
            this.statusStrip1.Location = new System.Drawing.Point(0, 417);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(443, 22);
            this.statusStrip1.TabIndex = 51;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // s_label
            // 
            this.s_label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.s_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.s_label.Name = "s_label";
            this.s_label.Size = new System.Drawing.Size(0, 17);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 260);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(419, 23);
            this.button2.TabIndex = 52;
            this.button2.Text = "CHECK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 53;
            this.label2.Text = ": DELTA :";
            // 
            // tb_delta
            // 
            this.tb_delta.Location = new System.Drawing.Point(377, 346);
            this.tb_delta.Name = "tb_delta";
            this.tb_delta.Size = new System.Drawing.Size(50, 22);
            this.tb_delta.TabIndex = 54;
            // 
            // tb_ksi_mono
            // 
            this.tb_ksi_mono.Location = new System.Drawing.Point(50, 295);
            this.tb_ksi_mono.Name = "tb_ksi_mono";
            this.tb_ksi_mono.Size = new System.Drawing.Size(82, 22);
            this.tb_ksi_mono.TabIndex = 55;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 296);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 17);
            this.label8.TabIndex = 56;
            this.label8.Text = "KSI :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 325);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 17);
            this.label9.TabIndex = 58;
            this.label9.Text = "KSI :";
            // 
            // tb_ksi_dual
            // 
            this.tb_ksi_dual.Location = new System.Drawing.Point(50, 324);
            this.tb_ksi_dual.Name = "tb_ksi_dual";
            this.tb_ksi_dual.Size = new System.Drawing.Size(82, 22);
            this.tb_ksi_dual.TabIndex = 57;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 382);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 17);
            this.label10.TabIndex = 62;
            this.label10.Text = "KSI :";
            // 
            // tb_ksi_poker
            // 
            this.tb_ksi_poker.Location = new System.Drawing.Point(50, 381);
            this.tb_ksi_poker.Name = "tb_ksi_poker";
            this.tb_ksi_poker.Size = new System.Drawing.Size(82, 22);
            this.tb_ksi_poker.TabIndex = 61;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 353);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 17);
            this.label11.TabIndex = 60;
            this.label11.Text = "KSI :";
            // 
            // tb_ksi_ser
            // 
            this.tb_ksi_ser.Location = new System.Drawing.Point(50, 352);
            this.tb_ksi_ser.Name = "tb_ksi_ser";
            this.tb_ksi_ser.Size = new System.Drawing.Size(82, 22);
            this.tb_ksi_ser.TabIndex = 59;
            // 
            // tb_poker
            // 
            this.tb_poker.Location = new System.Drawing.Point(138, 381);
            this.tb_poker.Name = "tb_poker";
            this.tb_poker.Size = new System.Drawing.Size(81, 22);
            this.tb_poker.TabIndex = 66;
            // 
            // tb_dual
            // 
            this.tb_dual.Location = new System.Drawing.Point(138, 324);
            this.tb_dual.Name = "tb_dual";
            this.tb_dual.Size = new System.Drawing.Size(81, 22);
            this.tb_dual.TabIndex = 65;
            // 
            // tb_ser
            // 
            this.tb_ser.Location = new System.Drawing.Point(138, 352);
            this.tb_ser.Name = "tb_ser";
            this.tb_ser.Size = new System.Drawing.Size(81, 22);
            this.tb_ser.TabIndex = 64;
            // 
            // tb_mono
            // 
            this.tb_mono.Location = new System.Drawing.Point(138, 295);
            this.tb_mono.Name = "tb_mono";
            this.tb_mono.Size = new System.Drawing.Size(81, 22);
            this.tb_mono.TabIndex = 63;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(443, 439);
            this.Controls.Add(this.tb_poker);
            this.Controls.Add(this.tb_dual);
            this.Controls.Add(this.tb_ser);
            this.Controls.Add(this.tb_mono);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_ksi_poker);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tb_ksi_ser);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_ksi_dual);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_ksi_mono);
            this.Controls.Add(this.tb_delta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tb_bin);
            this.Controls.Add(this.rtb_lang);
            this.Controls.Add(this.rb_uk);
            this.Controls.Add(this.rb_ru);
            this.Controls.Add(this.rb_en);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_in);
            this.Name = "Form1";
            this.Text = "Tests";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_in;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rtb_lang;
        private System.Windows.Forms.RadioButton rb_uk;
        private System.Windows.Forms.RadioButton rb_ru;
        private System.Windows.Forms.RadioButton rb_en;
        private System.Windows.Forms.RichTextBox tb_bin;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel s_label;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_delta;
        private System.Windows.Forms.TextBox tb_ksi_mono;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_ksi_dual;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_ksi_poker;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_ksi_ser;
        private System.Windows.Forms.TextBox tb_poker;
        private System.Windows.Forms.TextBox tb_dual;
        private System.Windows.Forms.TextBox tb_ser;
        private System.Windows.Forms.TextBox tb_mono;
    }
}

