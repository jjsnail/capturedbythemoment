using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Five
{
    public partial class Form1 : Form
    {
        string to_chipher = "ПРАВИЛО";
        List<List<char>> one_square = new List<List<char>>()
        {
new List<char>(){'Ж', 'Щ', 'Н', 'Ю', 'Р'},
new List<char>(){'И', 'Т', 'Ь', 'Ц', 'Б'},
new List<char>(){'Я', 'М', 'Е', '.', 'С'},
new List<char>(){'В', 'Ы', 'П', 'Ч', '_'},
new List<char>(){'Й', 'Д', 'У', 'О', 'К'},
new List<char>(){'З', 'Э', 'Ф', 'Г', 'Ш'},
new List<char>(){'Х', 'А', ',', 'Л', 'Ъ'}
        };
        List<List<char>> two_square = new List<List<char>>()
        {
new List<char>(){'И', 'Ч', 'Г', 'Я', 'Т'},
new List<char>(){',', 'Ж', 'Ь', 'М', 'О'},
new List<char>(){'З', 'Ю', 'Р', 'В', 'Щ'},
new List<char>(){'Ц', 'Й', 'П', 'Е', 'Л'},
new List<char>(){'Ъ', 'А', 'Н', '.', 'Х'},
new List<char>(){'Э', 'К', 'С', 'Ш', 'Д'},
new List<char>(){'Б', 'Ф', 'У', 'Ы', '_'}
        };

        public Form1()
        {
            InitializeComponent();
            dgv_one.ColumnHeadersVisible = false;
            dgv_one.RowHeadersVisible = false;
            dgv_one.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_one.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgv_one.DefaultCellStyle.SelectionBackColor = dgv_one.DefaultCellStyle.BackColor;
            dgv_one.DefaultCellStyle.SelectionForeColor = dgv_one.DefaultCellStyle.ForeColor;
            dgv_two.ColumnHeadersVisible = false;
            dgv_two.RowHeadersVisible = false;
            dgv_two.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_two.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgv_two.DefaultCellStyle.SelectionBackColor = dgv_two.DefaultCellStyle.BackColor;
            dgv_two.DefaultCellStyle.SelectionForeColor = dgv_two.DefaultCellStyle.ForeColor;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // fill the grid views
            tb_in.Text = to_chipher;
            for (int i = 0; i < one_square.First().Count; i++)
            {
                DataGridViewColumn col = new DataGridViewTextBoxColumn();
                dgv_one.Columns.Add(col);
            }

            for (int i = 0; i < one_square.Count; i++)
            {
                object[] rows = new object[one_square[i].Count];
                
                for (int j = 0; j < one_square[i].Count; j++)
                {
                    rows[j] = one_square[i][j];
                }
                dgv_one.Rows.Add(rows);
            }

            for (int i = 0; i < one_square.First().Count; i++)
            {
                DataGridViewColumn col = new DataGridViewTextBoxColumn();
                dgv_two.Columns.Add(col);
            }

            for (int i = 0; i < two_square.Count; i++)
            {
                object[] rows = new object[two_square[i].Count];

                for (int j = 0; j < two_square[i].Count; j++)
                {
                    rows[j] = two_square[i][j];
                }
                dgv_two.Rows.Add(rows);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string chiphered = "";
            tb_in.Text = to_chipher;
            for (int i = 0; i < to_chipher.Length; i += 2)
                chiphered += GetBi(to_chipher[i], to_chipher[i + 1]);
            tb_out.Text = chiphered;
        }

        private string GetBi(char p1, char p2)
        {
            if (one_square.Count == 0)
                throw new Exception("Left matrix shold be equal to right.");
            List<int[,]> ret = checkInputWord(p1, p2);
            int[,] ones = ret[0];
            int[,] twos = ret[0];
            int j_max = one_square[0].Count;

            char p_out1, p_out2;
            if (ones[0, 0] == twos[0, 0])
            {
                if (ones[0, 1] == twos[0, 1])
                {
                    p_out1 = two_square[twos[0, 0]][(twos[0, 1] + 1) % j_max];
                    p_out2 = one_square[ones[0, 0]][(ones[0, 1] + 1) % j_max];
                }
                else
                {
                    p_out1 = two_square[ones[0, 0]][ones[0, 1]];
                    p_out2 = one_square[twos[0, 0]][twos[0, 1]];
                }
                
            }
            else
            {
                p_out1 = one_square[twos[0, 0]][ones[0, 1]];
                p_out2 = two_square[ones[0, 0]][twos[0, 1]];
            }
            string res = "";
            res += p_out1;
            res += p_out2;
            return res;
        }

        private List<int[,]> checkInputWord(char p1, char p2)
        {
            int[,] ones = new int[1,2];
            ones[0, 1] = (ones[0, 1] = -1);
            int[,] twos = new int[1, 2];
            twos[0, 1] = (twos[0, 1] = -1);
            int i_max = one_square.Count;
            int j_max = one_square[0].Count;
            ones = new int[1, 2];
            ones[0, 1] = (ones[0, 0] = -1);
            twos = new int[1, 2];
            twos[0, 1] = (twos[0, 0] = -1);

            for (int i = 0; i < i_max; i++)
            {
                for (int j = 0; j < j_max; j++)
                {
                    if (one_square[i][j] == p1)
                    {
                        ones[0, 0] = i;
                        ones[0, 1] = j;
                    }
                    if (two_square[i][j] == p2)
                    {
                        twos[0, 0] = i;
                        twos[0, 1] = j;
                    }
                }
            }
            return new List<int[,]>() { ones, twos };
        }

        private void tb_in_TextChanged(object sender, EventArgs e)
        {
            try
            {
                to_chipher = tb_in.Text;
                s_label.Text = "";
                if (one_square.Count == 0)
                    throw new Exception("Left matrix shold be equal to right.");
                if (to_chipher.Length % 2 == 1)
                {
                    to_chipher += "_";
                }
                for (int i = 0; i < to_chipher.Length; i += 2)
                    checkInputWord(to_chipher[i], to_chipher[i + 1]);
            }
            catch (Exception)
            {
                s_label.Text = "Input has to contain letters only from tables.";
            }
            
        }
    }
}
