namespace crypto_twelve
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
            this.tb_a_dec = new System.Windows.Forms.TextBox();
            this.tb_a_1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_a_bin = new System.Windows.Forms.TextBox();
            this.tb_mod_bin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_mod = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_c1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.t = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_a = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_a_1_bin = new System.Windows.Forms.TextBox();
            this.tb_a_1_dec = new System.Windows.Forms.TextBox();
            this.rtb_c = new System.Windows.Forms.RichTextBox();
            this.tb_distance = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.l_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_a_dec
            // 
            this.tb_a_dec.Location = new System.Drawing.Point(96, 68);
            this.tb_a_dec.Name = "tb_a_dec";
            this.tb_a_dec.Size = new System.Drawing.Size(188, 22);
            this.tb_a_dec.TabIndex = 0;
            this.tb_a_dec.TextChanged += new System.EventHandler(this.tb_a_dec_TextChanged);
            // 
            // tb_a_1
            // 
            this.tb_a_1.Location = new System.Drawing.Point(420, 12);
            this.tb_a_1.Name = "tb_a_1";
            this.tb_a_1.ReadOnly = true;
            this.tb_a_1.Size = new System.Drawing.Size(194, 22);
            this.tb_a_1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "a_ij (dec):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "a_ij^(-1) :";
            // 
            // tb_a_bin
            // 
            this.tb_a_bin.Location = new System.Drawing.Point(96, 96);
            this.tb_a_bin.Name = "tb_a_bin";
            this.tb_a_bin.ReadOnly = true;
            this.tb_a_bin.Size = new System.Drawing.Size(188, 22);
            this.tb_a_bin.TabIndex = 4;
            // 
            // tb_mod_bin
            // 
            this.tb_mod_bin.Location = new System.Drawing.Point(96, 40);
            this.tb_mod_bin.Name = "tb_mod_bin";
            this.tb_mod_bin.Size = new System.Drawing.Size(188, 22);
            this.tb_mod_bin.TabIndex = 5;
            this.tb_mod_bin.TextChanged += new System.EventHandler(this.tb_mod_bin_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(389, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "C :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(373, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "C_1 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "mod (bin) :";
            // 
            // tb_mod
            // 
            this.tb_mod.Location = new System.Drawing.Point(96, 12);
            this.tb_mod.Name = "tb_mod";
            this.tb_mod.ReadOnly = true;
            this.tb_mod.Size = new System.Drawing.Size(188, 22);
            this.tb_mod.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 89);
            this.button1.TabIndex = 10;
            this.button1.Text = "GO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_c1
            // 
            this.tb_c1.Location = new System.Drawing.Point(420, 258);
            this.tb_c1.Name = "tb_c1";
            this.tb_c1.Size = new System.Drawing.Size(194, 22);
            this.tb_c1.TabIndex = 11;
            this.tb_c1.TextChanged += new System.EventHandler(this.tb_c1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "mod :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "a_ij (bin) :";
            // 
            // t
            // 
            this.t.AutoSize = true;
            this.t.Location = new System.Drawing.Point(316, 42);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(101, 17);
            this.t.TabIndex = 15;
            this.t.Text = "a_ij^(-1) (bin) :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(51, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "a_ij :";
            // 
            // tb_a
            // 
            this.tb_a.Location = new System.Drawing.Point(96, 126);
            this.tb_a.Name = "tb_a";
            this.tb_a.ReadOnly = true;
            this.tb_a.Size = new System.Drawing.Size(188, 22);
            this.tb_a.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(313, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 17);
            this.label11.TabIndex = 19;
            this.label11.Text = "a_ij^(-1) (dec) :";
            // 
            // tb_a_1_bin
            // 
            this.tb_a_1_bin.Location = new System.Drawing.Point(420, 39);
            this.tb_a_1_bin.Name = "tb_a_1_bin";
            this.tb_a_1_bin.ReadOnly = true;
            this.tb_a_1_bin.Size = new System.Drawing.Size(194, 22);
            this.tb_a_1_bin.TabIndex = 20;
            // 
            // tb_a_1_dec
            // 
            this.tb_a_1_dec.Location = new System.Drawing.Point(420, 67);
            this.tb_a_1_dec.Name = "tb_a_1_dec";
            this.tb_a_1_dec.ReadOnly = true;
            this.tb_a_1_dec.Size = new System.Drawing.Size(194, 22);
            this.tb_a_1_dec.TabIndex = 21;
            // 
            // rtb_c
            // 
            this.rtb_c.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rtb_c.Location = new System.Drawing.Point(420, 95);
            this.rtb_c.Name = "rtb_c";
            this.rtb_c.Size = new System.Drawing.Size(193, 157);
            this.rtb_c.TabIndex = 22;
            this.rtb_c.Text = "";
            this.rtb_c.TextChanged += new System.EventHandler(this.rtb_c_TextChanged);
            // 
            // tb_distance
            // 
            this.tb_distance.Location = new System.Drawing.Point(96, 261);
            this.tb_distance.Name = "tb_distance";
            this.tb_distance.ReadOnly = true;
            this.tb_distance.Size = new System.Drawing.Size(188, 22);
            this.tb_distance.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "DISTANCE :";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.l_status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 293);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(625, 22);
            this.statusStrip1.TabIndex = 25;
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
            this.ClientSize = new System.Drawing.Size(625, 315);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tb_distance);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rtb_c);
            this.Controls.Add(this.tb_a_1_dec);
            this.Controls.Add(this.tb_a_1_bin);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tb_a);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.t);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_c1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_mod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_mod_bin);
            this.Controls.Add(this.tb_a_bin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_a_1);
            this.Controls.Add(this.tb_a_dec);
            this.Name = "Form1";
            this.Text = "Distance";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_a_dec;
        private System.Windows.Forms.TextBox tb_a_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_a_bin;
        private System.Windows.Forms.TextBox tb_mod_bin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_mod;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_c1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label t;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_a;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_a_1_bin;
        private System.Windows.Forms.TextBox tb_a_1_dec;
        private System.Windows.Forms.RichTextBox rtb_c;
        private System.Windows.Forms.TextBox tb_distance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel l_status;
    }
}

