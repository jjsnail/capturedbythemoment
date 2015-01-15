namespace eight
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
            this.tb_11 = new System.Windows.Forms.TextBox();
            this.tb_12 = new System.Windows.Forms.TextBox();
            this.tb_22 = new System.Windows.Forms.TextBox();
            this.tb_21 = new System.Windows.Forms.TextBox();
            this.rtb_in = new System.Windows.Forms.RichTextBox();
            this.rtb_out = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.l_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.rtb_lang = new System.Windows.Forms.RichTextBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_11
            // 
            this.tb_11.Location = new System.Drawing.Point(13, 97);
            this.tb_11.Name = "tb_11";
            this.tb_11.Size = new System.Drawing.Size(69, 22);
            this.tb_11.TabIndex = 0;
            // 
            // tb_12
            // 
            this.tb_12.Location = new System.Drawing.Point(93, 97);
            this.tb_12.Name = "tb_12";
            this.tb_12.Size = new System.Drawing.Size(69, 22);
            this.tb_12.TabIndex = 1;
            // 
            // tb_22
            // 
            this.tb_22.Location = new System.Drawing.Point(93, 125);
            this.tb_22.Name = "tb_22";
            this.tb_22.Size = new System.Drawing.Size(69, 22);
            this.tb_22.TabIndex = 3;
            // 
            // tb_21
            // 
            this.tb_21.Location = new System.Drawing.Point(13, 125);
            this.tb_21.Name = "tb_21";
            this.tb_21.Size = new System.Drawing.Size(69, 22);
            this.tb_21.TabIndex = 2;
            // 
            // rtb_in
            // 
            this.rtb_in.Location = new System.Drawing.Point(12, 153);
            this.rtb_in.Name = "rtb_in";
            this.rtb_in.Size = new System.Drawing.Size(150, 74);
            this.rtb_in.TabIndex = 4;
            this.rtb_in.Text = "";
            this.rtb_in.TextChanged += new System.EventHandler(this.rtb_in_TextChanged);
            // 
            // rtb_out
            // 
            this.rtb_out.Location = new System.Drawing.Point(12, 262);
            this.rtb_out.Name = "rtb_out";
            this.rtb_out.ReadOnly = true;
            this.rtb_out.Size = new System.Drawing.Size(150, 74);
            this.rtb_out.TabIndex = 5;
            this.rtb_out.Text = "";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.l_status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 362);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(175, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // l_status
            // 
            this.l_status.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.l_status.ForeColor = System.Drawing.Color.Red;
            this.l_status.Name = "l_status";
            this.l_status.Size = new System.Drawing.Size(0, 17);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "GO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rtb_lang
            // 
            this.rtb_lang.Location = new System.Drawing.Point(12, 12);
            this.rtb_lang.Name = "rtb_lang";
            this.rtb_lang.Size = new System.Drawing.Size(150, 79);
            this.rtb_lang.TabIndex = 8;
            this.rtb_lang.Text = "";
            this.rtb_lang.TextChanged += new System.EventHandler(this.rtb_lang_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(175, 384);
            this.Controls.Add(this.rtb_lang);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.rtb_out);
            this.Controls.Add(this.rtb_in);
            this.Controls.Add(this.tb_22);
            this.Controls.Add(this.tb_21);
            this.Controls.Add(this.tb_12);
            this.Controls.Add(this.tb_11);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Hill\'s cipher";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_11;
        private System.Windows.Forms.TextBox tb_12;
        private System.Windows.Forms.TextBox tb_22;
        private System.Windows.Forms.TextBox tb_21;
        private System.Windows.Forms.RichTextBox rtb_in;
        private System.Windows.Forms.RichTextBox rtb_out;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel l_status;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox rtb_lang;
    }
}

