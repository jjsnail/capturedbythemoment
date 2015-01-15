namespace Five
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
            this.dgv_one = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_in = new System.Windows.Forms.TextBox();
            this.tb_out = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.s_label = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgv_two = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_one)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_two)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_one
            // 
            this.dgv_one.AllowUserToAddRows = false;
            this.dgv_one.AllowUserToDeleteRows = false;
            this.dgv_one.AllowUserToResizeColumns = false;
            this.dgv_one.AllowUserToResizeRows = false;
            this.dgv_one.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_one.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_one.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_one.Location = new System.Drawing.Point(12, 15);
            this.dgv_one.Name = "dgv_one";
            this.dgv_one.ReadOnly = true;
            this.dgv_one.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_one.RowTemplate.Height = 24;
            this.dgv_one.Size = new System.Drawing.Size(182, 150);
            this.dgv_one.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(201, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 22);
            this.button1.TabIndex = 2;
            this.button1.Text = "GO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_in
            // 
            this.tb_in.Location = new System.Drawing.Point(10, 177);
            this.tb_in.Name = "tb_in";
            this.tb_in.Size = new System.Drawing.Size(185, 22);
            this.tb_in.TabIndex = 3;
            this.tb_in.TextChanged += new System.EventHandler(this.tb_in_TextChanged);
            // 
            // tb_out
            // 
            this.tb_out.Location = new System.Drawing.Point(247, 177);
            this.tb_out.Name = "tb_out";
            this.tb_out.ReadOnly = true;
            this.tb_out.Size = new System.Drawing.Size(182, 22);
            this.tb_out.TabIndex = 4;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.s_label});
            this.statusStrip1.Location = new System.Drawing.Point(0, 215);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(446, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // s_label
            // 
            this.s_label.ForeColor = System.Drawing.Color.Red;
            this.s_label.Name = "s_label";
            this.s_label.Size = new System.Drawing.Size(0, 17);
            // 
            // dgv_two
            // 
            this.dgv_two.AllowUserToAddRows = false;
            this.dgv_two.AllowUserToDeleteRows = false;
            this.dgv_two.AllowUserToResizeColumns = false;
            this.dgv_two.AllowUserToResizeRows = false;
            this.dgv_two.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_two.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_two.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_two.Location = new System.Drawing.Point(247, 15);
            this.dgv_two.Name = "dgv_two";
            this.dgv_two.ReadOnly = true;
            this.dgv_two.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_two.RowTemplate.Height = 24;
            this.dgv_two.Size = new System.Drawing.Size(182, 150);
            this.dgv_two.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 237);
            this.Controls.Add(this.dgv_two);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tb_out);
            this.Controls.Add(this.tb_in);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_one);
            this.Name = "Form1";
            this.Text = "Winston\'s two-square";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_one)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_two)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_one;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_in;
        private System.Windows.Forms.TextBox tb_out;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel s_label;
        private System.Windows.Forms.DataGridView dgv_two;
    }
}

