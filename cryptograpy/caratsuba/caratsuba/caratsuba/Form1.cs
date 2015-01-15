using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caratsuba
{
    public partial class Form1 : Form
    {
        int u, v;
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

        int FromBinToDec(string bin)
        {
            double res = 0;
            for (int i = 0; i < bin.Length; i++)
            {
                if (bin[bin.Length - 1 - i] == '1')
                    res += Math.Pow(2, i);
            }
            return (int)res;
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
                if (bin[i] == '1')
                    view.Append("x^" + (bin.Length - 1 - i) + "+");
            }

            if (end == "") view = view.Remove(view.Length - 1, 1);
            else view.Append(end);

            return view.ToString();
        }

        string FromPolyToView(List<int> poly)
        {
            if (poly.Count == 0) return "";

            if (poly.Count == 1) return poly[0] != 0 ? poly[0].ToString() : "";

            string end = (poly[poly.Count - 2] != 0
                ? (poly[poly.Count - 1] != 0 ? poly[poly.Count - 2].ToString() + "*x+"+
                poly[poly.Count - 1] : poly[poly.Count - 2]+"*x")
                : (poly[poly.Count - 1] != 0 ? poly[poly.Count - 1].ToString() : ""));

            if (poly.Count == 2) return end;

            StringBuilder view = new StringBuilder();

            for (int i = 0; i < poly.Count - 2; i++)
            {
                if (poly[i] != 0)
                    view.Append(poly[i]+"*x^" + (poly.Count - 1 - i) + "+");
            }

            if (end == "") view = view.Remove(view.Length - 1, 1);
            else view.Append(end);

            return view.ToString();
        }

        int PolyByNum(List<int>poly, int num)
        {
            double res = 0;
            for (int i = 0; i < poly.Count; i++)
            {
                    res += poly[poly.Count - 1 - i]*Math.Pow(num, i);
            }
            return (int)res;
        }

        int Count(int u, int v)
        {
            int res = 0;

//translate in binary format
            string u_str = FromDecToBin(u);
            string v_str = FromDecToBin(v);
            for (int i = 0; i < u_str.Length % 4; i++)
                u_str = "0" + u_str;
            for (int i = 0; i < v_str.Length % 4; i++)
                v_str = "0" + v_str;
            List<int> us = new List<int>();
            List<int> vs = new List<int>();
            for (int i = 0; i < u_str.Length; i += 4)
                us.Add(FromBinToDec(new string(new char[]{u_str[i],u_str[i+1],
                    u_str[i+2],u_str[i+3]})));
            for (int i = 0; i < v_str.Length; i += 4)
                vs.Add(FromBinToDec(new string(new char[]{v_str[i],v_str[i+1],
                    v_str[i+2],v_str[i+3]})));
            tb_u_bin.Text = u_str;
            tb_v_bin.Text = v_str;

            tb_u_view.Text = FromPolyToView(us);
            tb_v_view.Text = FromPolyToView(vs);

            int[,] matrix_one = new int[5,3];
            for(int i = 0; i < 5; i++)
            {
                matrix_one[i,0] = PolyByNum(us,i);
                matrix_one[i, 1] = PolyByNum(vs, i);
                matrix_one[i, 2] = matrix_one[i, 0] * matrix_one[i, 1];
            }
            List<int>[] matrix_two = new List<int>[5];
            for (int i = 0; i < 5; i++)
            matrix_two[i] = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                matrix_two[0].Add(matrix_one[i, 2]);
            }
            for (int i = 0; i < 4; i++)
            {
                matrix_two[1].Add(matrix_two[0][i+1] - matrix_two[0][i]);
            }
            for (int i = 0; i < 3; i++)
            {
                matrix_two[2].Add((matrix_two[1][i + 1] - matrix_two[1][i])/2);
            }
            for (int i = 0; i < 2; i++)
            {
                matrix_two[3].Add((matrix_two[2][i + 1] - matrix_two[2][i]) / 3);
            }
                matrix_two[4].Add((matrix_two[3][1] - matrix_two[3][0]) / 4);
            List<int>[] matrix_three = new List<int>[3];
            for (int i = 0; i < 3; i++)
                matrix_three[i] = new List<int>();

            int last = matrix_two[4][0];
            matrix_three[0].Add(matrix_two[3][0]-(3*last));

            matrix_three[1].Add(matrix_three[0][0]-(2*last));
            matrix_three[1].Add(matrix_two[2][0]-(matrix_three[0][0] * 2));

            matrix_three[2].Add(matrix_three[1][0] - last);
            matrix_three[2].Add(matrix_three[1][1] - matrix_three[1][0]);
            matrix_three[2].Add(matrix_two[1][0] - matrix_three[1][1]);

            matrix_three[2].Insert(0,last);
            matrix_three[2].Add(matrix_two[0][0]);

            rtb_uxv_view.Text = FromPolyToView(matrix_three[2]);
            res = PolyByNum(matrix_three[2], 16);

            return res;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tb_uxv.Text = Count(u, v).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tb_u.Text = (1234).ToString();
            tb_v.Text = (2341).ToString();
        }

        private void tb_u_TextChanged(object sender, EventArgs e)
        {
            l_status.Text = "";
                if (!Int32.TryParse(tb_u.Text, out u))
            l_status.Text += ("Check input : u. ");
        }

        private void tb_v_TextChanged(object sender, EventArgs e)
        {
            l_status.Text = "";
            if (!Int32.TryParse(tb_v.Text, out v))
                l_status.Text += ("Check input : v. ");
        }
    }
}
