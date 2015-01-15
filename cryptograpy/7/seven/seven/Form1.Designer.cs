namespace seven
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_key = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.rtb_lang = new System.Windows.Forms.RichTextBox();
            this.b_crypt = new System.Windows.Forms.Button();
            this.rtb_input = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.l_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 56;
            this.label1.Text = "KEY";
            // 
            // tb_key
            // 
            this.tb_key.Location = new System.Drawing.Point(94, 111);
            this.tb_key.Name = "tb_key";
            this.tb_key.Size = new System.Drawing.Size(412, 22);
            this.tb_key.TabIndex = 55;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(94, 263);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(413, 83);
            this.richTextBox1.TabIndex = 54;
            this.richTextBox1.Text = "";
            // 
            // rtb_lang
            // 
            this.rtb_lang.Location = new System.Drawing.Point(94, 4);
            this.rtb_lang.Name = "rtb_lang";
            this.rtb_lang.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtb_lang.Size = new System.Drawing.Size(413, 101);
            this.rtb_lang.TabIndex = 53;
            this.rtb_lang.Text = "";
            // 
            // b_crypt
            // 
            this.b_crypt.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.b_crypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_crypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_crypt.ForeColor = System.Drawing.Color.White;
            this.b_crypt.Location = new System.Drawing.Point(23, 139);
            this.b_crypt.Name = "b_crypt";
            this.b_crypt.Size = new System.Drawing.Size(64, 118);
            this.b_crypt.TabIndex = 49;
            this.b_crypt.Text = "GO";
            this.b_crypt.UseVisualStyleBackColor = false;
            this.b_crypt.Click += new System.EventHandler(this.b_crypt_Click);
            // 
            // rtb_input
            // 
            this.rtb_input.Location = new System.Drawing.Point(94, 139);
            this.rtb_input.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rtb_input.Name = "rtb_input";
            this.rtb_input.Size = new System.Drawing.Size(413, 118);
            this.rtb_input.TabIndex = 48;
            this.rtb_input.Text = "";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.l_status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 373);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(530, 22);
            this.statusStrip1.TabIndex = 57;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // l_status
            // 
            this.l_status.ForeColor = System.Drawing.Color.Red;
            this.l_status.Name = "l_status";
            this.l_status.Size = new System.Drawing.Size(0, 17);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 395);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_key);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.rtb_lang);
            this.Controls.Add(this.b_crypt);
            this.Controls.Add(this.rtb_input);
            this.Name = "Form1";
            this.Text = "Gronsfeld\'s cipher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_key;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox rtb_lang;
        private System.Windows.Forms.Button b_crypt;
        private System.Windows.Forms.RichTextBox rtb_input;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel l_status;
    }
}

