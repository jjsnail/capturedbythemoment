using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eight
{
    public partial class Form1 : Form
    {
        string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ_";
        int[,] m = new int[,]
        {
            {3, 1},
            {6, 5},
        };
        string input = "DONALD_DUCK";

        public Form1()
        {
            InitializeComponent();
            tb_11.Text = m[0, 0].ToString();
            tb_12.Text = m[0, 1].ToString();
            tb_21.Text = m[1, 0].ToString();
            tb_22.Text = m[1, 1].ToString();
            rtb_in.Text = input;
            rtb_lang.Text = alphabet;
        }

        private string Get()
        {
            string res = "";
            for (int i = 0; i < input.Length; i += 2)
            {
                int[] inds = new int[]
                {
                    alphabet.IndexOf(input[i]),
                    alphabet.IndexOf(input[i+1])
                };
                int[] out_inds = new int[]
                {
                    (m[0,0]*inds[0] + m[0,1]*inds[1]) % alphabet.Length,
                    (m[1,0]*inds[0] + m[1,1]*inds[1]) % alphabet.Length
                };
                res += alphabet[out_inds[0]];
                res += alphabet[out_inds[1]];
            }
            return res;
        }

        private void checkForUnique()
        {
            List<char> alp = new List<char>();
            foreach (var ch in alphabet)
            {
                if (alp.Contains(ch)) throw new Exception("Alphabet should contain only unique symbols.");
                else alp.Add(ch);
            }
            foreach (var ch in input)
            {
                if (!alp.Contains(ch)) throw new Exception("Input should contain only symbols from alphabet.");
            }
                bool wrong = false;
                for (; ; )
                {
                    if (!Int32.TryParse(tb_11.Text, out m[0, 0]) || m[0, 0] < 0)
                    {
                        wrong = true;
                        break;
                    }
                    if (!Int32.TryParse(tb_12.Text, out m[0, 1]) || m[0, 1] < 0)
                    {
                        wrong = true;
                        break;
                    }
                    if (!Int32.TryParse(tb_21.Text, out m[1, 0]) || m[1, 0] < 0)
                    {
                        wrong = true;
                        break;
                    }
                    if (!Int32.TryParse(tb_22.Text, out m[1, 1]) || m[1, 1] < 0)
                    {
                        wrong = true;
                        break;
                    }
                    break;
                }
                if (wrong)
                    throw new Exception("Matrix key should contain only positive numbers.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            rtb_out.Text = "";
            input += (input.Length % 2 == 0) ? "" : "_";
            checkForUnique();
            rtb_in.Text = input;
            rtb_out.Text = Get();
            }
            catch (Exception exc)
            {
                rtb_out.Text = exc.Message;
            }
        }

        private void rtb_in_TextChanged(object sender, EventArgs e)
        {
            try
            {
                rtb_out.Text = "";
                input = rtb_in.Text;
                checkForUnique();
            }
            catch (Exception exc)
            {
                rtb_out.Text = exc.Message;
            }
        }

        private void rtb_lang_TextChanged(object sender, EventArgs e)
        {
            try
            {
                rtb_out.Text = "";
                alphabet = rtb_lang.Text;
                checkForUnique();
            }
            catch (Exception exc)
            {
                rtb_out.Text = exc.Message;
            }
        }
    }
}
