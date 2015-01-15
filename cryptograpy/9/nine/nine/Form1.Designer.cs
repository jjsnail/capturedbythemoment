namespace nine
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.s_label = new System.Windows.Forms.ToolStripStatusLabel();
            this.rtb_in = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cb_invers = new System.Windows.Forms.CheckBox();
            this.cb_cyc = new System.Windows.Forms.CheckBox();
            this.cb_rises = new System.Windows.Forms.CheckBox();
            this.cb_coi = new System.Windows.Forms.CheckBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.s_label});
            this.statusStrip1.Location = new System.Drawing.Point(0, 175);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(408, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // s_label
            // 
            this.s_label.ForeColor = System.Drawing.Color.Red;
            this.s_label.Name = "s_label";
            this.s_label.Size = new System.Drawing.Size(0, 17);
            // 
            // rtb_in
            // 
            this.rtb_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtb_in.Location = new System.Drawing.Point(13, 13);
            this.rtb_in.Name = "rtb_in";
            this.rtb_in.Size = new System.Drawing.Size(379, 60);
            this.rtb_in.TabIndex = 12;
            this.rtb_in.Text = "";
            this.rtb_in.TextChanged += new System.EventHandler(this.tb_in_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 40);
            this.button1.TabIndex = 13;
            this.button1.Text = "Check";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_invers
            // 
            this.cb_invers.AutoCheck = false;
            this.cb_invers.AutoSize = true;
            this.cb_invers.Location = new System.Drawing.Point(13, 141);
            this.cb_invers.Name = "cb_invers";
            this.cb_invers.Size = new System.Drawing.Size(136, 21);
            this.cb_invers.TabIndex = 14;
            this.cb_invers.Text = "inversions test s.";
            this.cb_invers.UseVisualStyleBackColor = true;
            // 
            // cb_cyc
            // 
            this.cb_cyc.AutoCheck = false;
            this.cb_cyc.AutoSize = true;
            this.cb_cyc.Location = new System.Drawing.Point(174, 141);
            this.cb_cyc.Name = "cb_cyc";
            this.cb_cyc.Size = new System.Drawing.Size(111, 21);
            this.cb_cyc.TabIndex = 15;
            this.cb_cyc.Text = "cycles test s.";
            this.cb_cyc.UseVisualStyleBackColor = true;
            // 
            // cb_rises
            // 
            this.cb_rises.AutoCheck = false;
            this.cb_rises.AutoSize = true;
            this.cb_rises.Location = new System.Drawing.Point(303, 141);
            this.cb_rises.Name = "cb_rises";
            this.cb_rises.Size = new System.Drawing.Size(102, 21);
            this.cb_rises.TabIndex = 16;
            this.cb_rises.Text = "rises test s.";
            this.cb_rises.UseVisualStyleBackColor = true;
            // 
            // cb_coi
            // 
            this.cb_coi.AutoCheck = false;
            this.cb_coi.AutoSize = true;
            this.cb_coi.Location = new System.Drawing.Point(174, 98);
            this.cb_coi.Name = "cb_coi";
            this.cb_coi.Size = new System.Drawing.Size(185, 21);
            this.cb_coi.TabIndex = 17;
            this.cb_coi.Text = "coincidents test succeed";
            this.cb_coi.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 197);
            this.Controls.Add(this.cb_coi);
            this.Controls.Add(this.cb_rises);
            this.Controls.Add(this.cb_cyc);
            this.Controls.Add(this.cb_invers);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rtb_in);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "R.K.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel s_label;
        private System.Windows.Forms.RichTextBox rtb_in;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cb_invers;
        private System.Windows.Forms.CheckBox cb_cyc;
        private System.Windows.Forms.CheckBox cb_rises;
        private System.Windows.Forms.CheckBox cb_coi;
    }
}

