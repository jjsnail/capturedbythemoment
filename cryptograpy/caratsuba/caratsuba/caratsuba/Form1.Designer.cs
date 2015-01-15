namespace caratsuba
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
            this.button1 = new System.Windows.Forms.Button();
            this.tb_u = new System.Windows.Forms.TextBox();
            this.tb_v = new System.Windows.Forms.TextBox();
            this.tb_uxv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.l_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_u_bin = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_u_view = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_v_view = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_v_bin = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rtb_uxv_view = new System.Windows.Forms.RichTextBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(347, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "GO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_u
            // 
            this.tb_u.Location = new System.Drawing.Point(102, 12);
            this.tb_u.Name = "tb_u";
            this.tb_u.Size = new System.Drawing.Size(155, 22);
            this.tb_u.TabIndex = 1;
            this.tb_u.TextChanged += new System.EventHandler(this.tb_u_TextChanged);
            // 
            // tb_v
            // 
            this.tb_v.Location = new System.Drawing.Point(102, 96);
            this.tb_v.Name = "tb_v";
            this.tb_v.Size = new System.Drawing.Size(155, 22);
            this.tb_v.TabIndex = 2;
            this.tb_v.TextChanged += new System.EventHandler(this.tb_v_TextChanged);
            // 
            // tb_uxv
            // 
            this.tb_uxv.Location = new System.Drawing.Point(102, 227);
            this.tb_uxv.Name = "tb_uxv";
            this.tb_uxv.ReadOnly = true;
            this.tb_uxv.Size = new System.Drawing.Size(198, 22);
            this.tb_uxv.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "U (dec):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "U x V (dec):";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.l_status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 326);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(371, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // l_status
            // 
            this.l_status.ForeColor = System.Drawing.Color.Red;
            this.l_status.Name = "l_status";
            this.l_status.Size = new System.Drawing.Size(0, 17);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "U x V :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "U (bin):";
            // 
            // tb_u_bin
            // 
            this.tb_u_bin.Location = new System.Drawing.Point(102, 40);
            this.tb_u_bin.Name = "tb_u_bin";
            this.tb_u_bin.ReadOnly = true;
            this.tb_u_bin.Size = new System.Drawing.Size(198, 22);
            this.tb_u_bin.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "U :";
            // 
            // tb_u_view
            // 
            this.tb_u_view.Location = new System.Drawing.Point(102, 68);
            this.tb_u_view.Name = "tb_u_view";
            this.tb_u_view.ReadOnly = true;
            this.tb_u_view.Size = new System.Drawing.Size(198, 22);
            this.tb_u_view.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "V :";
            // 
            // tb_v_view
            // 
            this.tb_v_view.Location = new System.Drawing.Point(102, 152);
            this.tb_v_view.Name = "tb_v_view";
            this.tb_v_view.ReadOnly = true;
            this.tb_v_view.Size = new System.Drawing.Size(198, 22);
            this.tb_v_view.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "V (bin):";
            // 
            // tb_v_bin
            // 
            this.tb_v_bin.Location = new System.Drawing.Point(102, 124);
            this.tb_v_bin.Name = "tb_v_bin";
            this.tb_v_bin.ReadOnly = true;
            this.tb_v_bin.Size = new System.Drawing.Size(198, 22);
            this.tb_v_bin.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "V (dec):";
            // 
            // rtb_uxv_view
            // 
            this.rtb_uxv_view.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.rtb_uxv_view.Location = new System.Drawing.Point(102, 256);
            this.rtb_uxv_view.Name = "rtb_uxv_view";
            this.rtb_uxv_view.ReadOnly = true;
            this.rtb_uxv_view.Size = new System.Drawing.Size(257, 57);
            this.rtb_uxv_view.TabIndex = 23;
            this.rtb_uxv_view.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(371, 348);
            this.Controls.Add(this.rtb_uxv_view);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_v_view);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_v_bin);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_u_view);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_u_bin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_uxv);
            this.Controls.Add(this.tb_v);
            this.Controls.Add(this.tb_u);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Caratsuba 2^4";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_u;
        private System.Windows.Forms.TextBox tb_v;
        private System.Windows.Forms.TextBox tb_uxv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel l_status;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_u_bin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_u_view;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_v_view;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_v_bin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox rtb_uxv_view;
    }
}

