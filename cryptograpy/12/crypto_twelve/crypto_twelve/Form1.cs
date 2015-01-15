using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crypto_twelve
{
    public partial class Form1 : Form
    {
        List<string> c = new List<string>()
        {
            "11111000",
            "01111100",
            "00111110",
            "00011111",
            "10001111",
            "11000111",
            "11100011",
            "11110001"
        };
        string c1 = "01100011";
        string mod_view;
        string mod_bin = "100011011";

        string a_view;
        int a_dec = 123;
        string a_bin;

        string a1_view;
        int a1_dec;
        string a1_bin;

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
        string FromBinToView(string bin)
        {
            checkBinFormat(bin);

            if (bin.Length == 0) return "";

            if (bin.Length == 1) return bin[0] == '1' ? "1" : "";

            string end = (bin[bin.Length - 2] == '1'
                ? (bin[bin.Length - 1] == '1' ? "x+1" : "x")
                : (bin[bin.Length - 1] == '1' ? "1" : "")); 

            if (bin.Length == 2) return end;           

            StringBuilder view = new StringBuilder();
            int i = 0;
            while (i < bin.Length && bin[i] == '0')
                i++;
            for (; i < bin.Length - 2; i++)
            {
                if(bin[i] == '1')
                    view.Append("x^"+ (bin.Length - 1- i)+"+");
            }

            if (end == "") view = view.Remove(view.Length - 1, 1);
            else view.Append(end);

            return view.ToString();
        }

        string FromBinMatrixToView(List<string> matrix)
        {
            StringBuilder str = new StringBuilder();
            foreach (var s in matrix)
                str.Append(s+"\n");
            return str.ToString();
        }

        List<string> FromViewToBinMatrix(string view)
        {
            List<string> matrix = new List<string>(view.Split('\n'));
            matrix.Remove("");
            foreach (var s in matrix)
                checkBinFormat(s);
            return matrix;
        }

        int FromBinToDec(string bin)
        {
            double res = 0;
            for (int i = 0; i < bin.Length; i++)
            {
               if(bin[bin.Length - 1 - i] == '1')
               res += Math.Pow(2, i);
            }
                return (int)res;
        }

        public Form1()
        {
            InitializeComponent();
        }

        void fillMods()
        {
                mod_bin = tb_mod_bin.Text;
                if (mod_bin == "")
                    mod_view = "";
                else
                    mod_view = FromBinToView(tb_mod_bin.Text);
                    tb_mod.Text = mod_view;
        }

        void fillAs()
        {
            string a = tb_a_dec.Text;
            if (a == "")
                a_bin = "";
            else
            {
                if (!Int32.TryParse(a, out a_dec))
                    throw new Exception("Wrong decimal format.");
                a_bin = FromDecToBin(a_dec);
            }
            a_view = FromBinToView(a_bin);
            tb_a_bin.Text = a_bin;
            tb_a.Text = a_view;
        }

        void fillA1s()
        {
            tb_a_1_bin.Text = a1_bin;
            a_view = FromBinToView(a1_bin);
            tb_a_1.Text = a_view;
            if (a1_bin == "")
                tb_a_1_dec.Text = "";
            else
                tb_a_1_dec.Text = FromBinToDec(a1_bin).ToString();

        }

        void checkBinFormat(string input)
        {
            l_status.Text = "";
            foreach (var sym in input)
            {
                if (sym != '0' && sym != '1')
                    throw new Exception("Wrong binary format.");
            }
        }

        string BinMatrixXBin(List<string> matrix, string bin, string xor_vector)
        {
            string a = bin;
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < a.Length; i++)
                str.Append(a[a.Length - 1 - i]);
            for (int i = 0; i < c.Count - a.Length; i++)
                str.Append("0");
            bin = str.ToString();

            StringBuilder cells = new StringBuilder();
            foreach(var s in matrix)
            {
                if (s.Length != bin.Length)
                    throw new Exception(" Matrix C & vector aji_-1 dimensions are incompatible");
            }
            if (xor_vector.Length != matrix.Count)
                    throw new Exception(" Matrix C & vector C1 dimensions are incompatible");
            for (int cell = 0; cell < matrix.Count; cell++)
            {
                int sum = 0;
            for (int i = 0; i < bin.Length; i++)
            {
                if (!(matrix[cell][i] == '0' || bin[i] == '0'))
                    sum++;
            }
            if (sum % 2 == 0)
                cells.Append("0");
            else
                cells.Append("1");
            }
            for (int cell = 0; cell < xor_vector.Length; cell++)
            {
                if (xor_vector[cell] == cells[cell])
                    cells[cell] = '0';
                else
                    cells[cell] = '1';
            }
                return cells.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
            tb_mod_bin.Text = mod_bin;
            tb_a_dec.Text = a_dec.ToString();
            fillAs();
            fillMods();
            rtb_c.Text = FromBinMatrixToView(c);
            tb_c1.Text = c1;
            }
            catch (Exception exc)
            {
                l_status.Text = "Check input. " + exc.Message;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                a1_bin = InverseA.Get(mod_bin, a_bin);
                fillA1s();
                string output = BinMatrixXBin(c, a1_bin, c1);
                StringBuilder str = new StringBuilder();
                for (int i = 0; i < output.Length; i++)
                    str.Append(output[output.Length - 1 - i]);
                output = str.ToString();

                string diff = InverseA.BinPlusBin(a_bin, output);
                int count = 0;
                foreach(var sym in diff)
                {
                    if (sym == '1') count++;               
                }
                tb_distance.Text = count.ToString();
            }
            catch (Exception exc)
            {
                l_status.Text = "Check input. " + exc.Message;
            }
        }

        private void tb_mod_bin_TextChanged(object sender, EventArgs e)
        {
            try
            {
            fillMods();
            }
            catch (Exception exc)
            {
                l_status.Text = "Check input. " + exc.Message;
            }
        }

        private void tb_a_dec_TextChanged(object sender, EventArgs e)
        {
            try
            {
                fillAs();
            }
            catch (Exception exc)
            {
                l_status.Text = "Check input. " + exc.Message;
            }
        }

        private void rtb_c_TextChanged(object sender, EventArgs e)
        {
            try
            {
                c = FromViewToBinMatrix(rtb_c.Text);
            }
            catch (Exception exc)
            {
                l_status.Text = "Check input. " + exc.Message;
            }
        }

        private void tb_c1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                checkBinFormat(tb_c1.Text);
                c1 = tb_c1.Text;
            }
            catch (Exception exc)
            {
                l_status.Text = "Check input. " + exc.Message;
            }
        }
    }
}
