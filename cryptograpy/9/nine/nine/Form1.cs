using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nine
{
    public partial class Form1 : Form
    {
        List<int> input = new List<int>()
        {1,	15,	13,	0,	5,	7,	10,	4,	9,	2,	3,	14,	6,	11,	8,	12};

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StringBuilder str = new StringBuilder();
            foreach (var val in input)
            {
                str.Append(val + " ");
            }
            rtb_in.Text = str.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool coi = true;
            for (int i = 0; i < input.Count; i++)
            {
                if (i == input[i])
                {
                    coi = false;
                    break;
                }
            }
            cb_coi.Checked = coi;
            int invs = 0;
            for (int i = 0; i < input.Count; i++)
            {
                for (int j = i; j < input.Count; j++)
                {
                    if (input[i] > input[j])
                        invs++;
                }
            }
            cb_invers.Checked = invs < 50 ? false :
                    (invs > 70 ? false : true);
            int cycs = 0;

            List<int> copycopy = new List<int>();
            foreach(var el in input)
                copycopy.Add(el);
            for (int i = 0; i < copycopy.Count; i++)
            {
                if (copycopy[i] == -1) continue;
                int orig = i;
                int next = -1;
                while (orig != -1)
                {
                    next = copycopy[orig];
                    copycopy[orig] = -1;
                    orig = next;
                }
                cycs++;
            }
            cb_cyc.Checked =   cycs < 1 ? 
                false :
                   (cycs > 5 ? 
                   false : 
                   true);
            int rises = 0;
            for (int j = 0; j < input.Count - 1; j++)
            {
                if (input[j] < input[j+1])
                    rises++;
            }
            cb_rises.Checked = rises < 7 ? false :
               (rises > 9 ? false : true);
        }

        private void tb_in_TextChanged(object sender, EventArgs e)
        {
            try
            {
                s_label.Text = "";
                input.Clear();
                string[] parts = rtb_in.Text.Split(' ', '\n', ',');
                foreach (string val in parts)
                {
                    int some = 0;
                    if (val == "") continue;
                    input.Add(some = Int32.Parse(val));
                    if (some < 0) throw new Exception();
                }
                if (input.Count != 16) throw new Exception();
            }
            catch (Exception)
            {
                s_label.Text = "Input has to contain 16 positive numbers.";
            }

        }
    }
}
