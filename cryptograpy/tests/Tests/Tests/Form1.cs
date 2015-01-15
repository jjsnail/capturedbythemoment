using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tests
{
    public partial class Form1 : Form
    {
        string alphabet;
        string ENLang = "ABCDEFGHIJKLMNOPQRSTUVWXYZ_";
        string RULang = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ_";
        string UKLang = "АБВГҐДЕЄЖЗИІЇЙКЛМНОПРСТУФХЦЧШЩЬЮЯ_";
        int digit_am = 0;
        string text_format = "МАРТИНЕНКО НАТАЛІЯ";

        
        const double Delta = 0.05;
        const double KsiMono = 3.84146;
        const double KsiDual = 5.99146;
        const double KsiSer = 9.48773;
        const double KsiPoker = 14.06714;

        List<int> decs = new List<int>();
        public Form1()
        {
            InitializeComponent();
            alphabet = UKLang;
            rtb_lang.Text = alphabet;
            rb_uk.Checked = true;
            tb_ksi_mono.Text = KsiMono.ToString();
            tb_ksi_dual.Text = KsiDual.ToString();
            tb_ksi_ser.Text = KsiSer.ToString();
            tb_ksi_poker.Text = KsiPoker.ToString();
            tb_delta.Text = Delta.ToString();
        }
        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            switch (((RadioButton)sender).Text)
            {
                case "UK":
                    rtb_lang.Text = UKLang;
                    break;
                case "RU":
                    rtb_lang.Text = RULang;
                    break;
                case "EN":
                    rtb_lang.Text = ENLang;
                    break;
            }
        }
        string Filtrate(string initial)
        {
            string res = "";
            foreach (var sym in initial)
            {
                if (sym == ' ' || res.Contains(sym))
                    continue;
                res += sym;
            }
            return res;
        }
        private void CheckForAccordAndUnique(string text_format, string p)
        {
            List<char> alp = new List<char>();
            foreach (var ch in p)
            {
                if (alp.Contains(ch)) throw new Exception("Alphabet should contain only unique symbols!");
                else alp.Add(ch);
            }
            foreach (var sym in text_format)
            {
                if (!p.Contains(sym))
                    throw new Exception("Input should contain only symbols from alphabet!");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            tb_in.Text = text_format;
            FindDigitAmount();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                s_label.Text = "";
                text_format = tb_in.Text;
                if (text_format.Length == 0) return;
                tb_in.Text = (text_format = Filtrate(text_format));
                CheckForAccordAndUnique(text_format, rtb_lang.Text);
                digit_am = FindDigitAmount();
                string bins = TextToBins();
                while (bins.Length < 160)
                    bins += bins;
                tb_bin.Text = (bins = bins.Remove(160));

            }
            catch(Exception exc)
            {
                s_label.Text = exc.Message;
            }
        }

        private int FindDigitAmount()
        {
            int len = FromDecToBin(alphabet.Length).Length;
            int bi = 1;
            int when = 1;
            while (bi < len)
            {
                when++;
                bi *= 2;
            }
            return when;
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
        private string DecsToBins()
        {
            StringBuilder str = new StringBuilder();
            foreach (var num in decs)
            {
                string digit = FromDecToBin(num);
                while (digit.Length < digit_am)
                    digit = "0" + digit;
                str.Append(digit);
            }
            return str.ToString();
        }
        private string TextToBins()
        {
            StringBuilder str = new StringBuilder();
            foreach (var sym in text_format)
            {
                str.Append(FromDecToBin(alphabet.IndexOf(sym)));
            }
            return str.ToString();
        }

        void checkBinFormat()
        {
            string before = tb_bin.Text;
            if (before.Length == 0) throw new Exception("Binary sequence is empty!");
            foreach (var sym in before)
            {
                if (sym != '0' && sym != '1')
                {
                    throw new Exception("Wrong binary format!");
                }
            }
        }
        private void tb_bin_TextChanged(object sender, EventArgs e)
        {
            try
            {
                checkBinFormat();
            }
            catch (Exception exc)
            {
                s_label.Text = exc.Message;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                checkBinFormat();
                tb_mono.Text = MonoCheck(tb_bin.Text);
                tb_dual.Text = DualCheck(tb_bin.Text);
                tb_ser.Text = SerCheck(tb_bin.Text);
                tb_poker.Text = PokerCheck(tb_bin.Text);
            }
            catch (Exception exc)
            {
                s_label.Text = exc.Message;
            }
        }

        private string MonoCheck(string p)
        {
            if (p.Length < 1) return "";
            int zeros = 0;
            int uns = 0;
            foreach(var sym in p)
            {
                if (sym == '0') zeros++;
                else if (sym == '1') uns++;
            }
            double res = Math.Pow(zeros - uns, 2.0)/(zeros+uns);
            return Math.Round(res, 5).ToString();
        }

        private string DualCheck(string p)
        {
            if (p.Length < 2) return "";
            List<object[]> seqs = new List<object[]>()
            {
            new object[]{"00", 0.0},
            new object[]{"01", 0.0},
            new object[]{"10", 0.0},
            new object[]{"11", 0.0},
            };
            for (int i = 0; i < p.Length - 1; i++)
                {
                    string bits = ("" + p[i]) + p[i+1];
                    foreach (var val in seqs)
                    {
                        if (((string)val[0]).CompareTo(bits) == 0)
                        {
                            val[1] = ((double)val[1]) + 1.0;
                            break;
                        }
                    }
                }
            double pows = 0.0;
            foreach (var val in seqs)
            {
                pows += Math.Pow(((double)val[1]), 2.0);
            }
            double res = 4.0 / (p.Length - 1) * pows - 2.0/p.Length;
            return Math.Round(res, 5).ToString();
        }

        private string SerCheck(string p)
        {
            if (p.Length < 3) return "";
            List<object[]> seqs0 = new List<object[]>()
            {
            new object[]{"101", 0.0},
            new object[]{"1001", 0.0},
            new object[]{"10001", 0.0}
            };
            List<object[]> seqs1 = new List<object[]>()
            {
            new object[]{"010", 0.0},
            new object[]{"0110", 0.0},
            new object[]{"01110", 0.0}
            };
            for (int i = 0; i < p.Length - 2; i++)
            {
                string bin = (("" + p[i]) + p[i + 1])+p[i + 2];
                if (((string)seqs0[0][0]).CompareTo(bin) == 0)
                  seqs0[0][1] = ((double)seqs0[0][1]) + 1.0;
                if (((string)seqs1[0][0]).CompareTo(bin) == 0)
                    seqs1[0][1] = ((double)seqs1[0][1]) + 1.0;
            }
            for (int i = 0; i < p.Length - 3; i++)
            {
                string bin = ((("" + p[i]) + p[i + 1]) + p[i + 2]) + p[i + 3];
                if (((string)seqs0[1][0]).CompareTo(bin) == 0)
                    seqs0[1][1] = ((double)seqs0[1][1]) + 1.0;
                if (((string)seqs1[1][0]).CompareTo(bin) == 0)
                    seqs1[1][1] = ((double)seqs1[1][1]) + 1.0;
            }
            for (int i = 0; i < p.Length - 4; i++)
            {
                string bin = (((("" + p[i]) + p[i + 1]) + p[i + 2]) + p[i + 3]) + p[i+4];
                if (((string)seqs0[2][0]).CompareTo(bin) == 0)
                    seqs0[2][1] = ((double)seqs0[2][1]) + 1.0;
                if (((string)seqs1[2][0]).CompareTo(bin) == 0)
                    seqs1[2][1] = ((double)seqs1[2][1]) + 1.0;
            }
            double summ = 0.0;
            for(int i = 0; i < 3; i++)
            {
                double l = (p.Length - i + 1+3.0)/Math.Pow(2.0, i + 1+2.0);
                summ += Math.Pow((double)seqs0[i][1] - l, 2.0)/l;
                summ += Math.Pow((double)seqs1[i][1] - l, 2.0)/l;
            }
            return Math.Round(summ, 5).ToString();
        }

        private string PokerCheck(string p)
        {
            if (p.Length < 3) return "";
            int k = p.Length / 3;
            if (p.Length %3 > 0)
            p = p.Remove(p.Length - p.Length % 3);
            List<object[]> seqs = new List<object[]>()
            {
            new object[]{"000", 0.0},
            new object[]{"001", 0.0},
            new object[]{"010", 0.0},
            new object[]{"100", 0.0},
            new object[]{"011", 0.0},
            new object[]{"110", 0.0},
            new object[]{"101", 0.0},
            new object[]{"111", 0.0}
            };
            for (int i = 0; i < k; i++)
            {
                string bits = (("" + p[i * 3]) + p[i * 3 + 1]) + p[i * 3 + 2];

                foreach (var val in seqs)
                {
                    if (((string)val[0]).CompareTo(bits) == 0)
                    {
                        val[1] = ((double)val[1])+1.0;
                        break;
                    }
                }
            }
            double pows = 0.0;
            foreach (var val in seqs)
            {
                pows += Math.Pow(((double)val[1]), 2.0);
            }
            double res = 8.0/k*pows - k;
            return Math.Round(res, 5).ToString();
        }
    }
}
