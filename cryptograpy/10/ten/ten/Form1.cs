using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ten
{
    public partial class Form1 : Form
    {
        int a = 5, b = 13;
        int x = 0, y = 0;

        public Form1()
        {
            InitializeComponent();
        }

        void GCD(int a, int b)
        {
            int r = 0;
            int r_2 = a;
            int r_1 = b;
            int d = 0;
            
            int x_1 = 0, x_2 = 1;
            int y_1 = 1, y_2 = 0;
            for (;;)
            {
                d = r_2 / r_1;
                r = r_2 - d * r_1;
                if (r <= 0) return;
                x = x_2 - d * x_1;
                y = y_2 - d * y_1;
                r_2 = r_1;
                r_1 = r;
                x_2 = x_1;
                y_2 = y_1;
                x_1 = x;
                y_1 = y;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                a = Int32.Parse(tb_a.Text);
                b = Int32.Parse(tb_b.Text);
                GCD(a, b);
                tb_x.Text = x.ToString();
                tb_y.Text = y.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Check input.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tb_a.Text = (a).ToString();
            tb_b.Text = (b).ToString();
        }
    }
}
