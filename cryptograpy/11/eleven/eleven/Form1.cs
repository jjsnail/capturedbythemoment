using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eleven
{
    public partial class Form1 : Form
    {
        int a, b, n;

        public Form1()
        {
            InitializeComponent();
        }

        string FromDecToBin(int dec)
        {
            if (dec == 0) return "0";
            if (dec == 1) return "1";
            StringBuilder str = new StringBuilder();
            while (dec != 0)
            {
                if (dec % 2 == 0)
                    str.Append("0");
                else
                    str.Append("1");
                dec = dec / 2;
            }
            StringBuilder str_rev = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
                str_rev.Append(str[i]);
            return str_rev.ToString();
        }

        int CountMulti(int a, int b, int n)
        {
            string str_a = FromDecToBin(a);
            int r = 0;
            for (int i = 0; i < str_a.Length; i++)
            {
                if (str_a[i] == '1') r += b;
                if (r % 2 == 1) r = r + n;
                r /= 2;
            }
            if (r >= n) r = r - n;
            return r;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                a = Int32.Parse(tb_a.Text);
                b = Int32.Parse(tb_b.Text);
                n = Int32.Parse(tb_n.Text);
                rtb_result.Text = CountMulti(a, b, n).ToString();
            }
            catch(Exception)
            {
                MessageBox.Show("Check input.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tb_a.Text = (25).ToString();
            tb_b.Text = (20).ToString();
            tb_n.Text = (41).ToString();
        }
    }
}
