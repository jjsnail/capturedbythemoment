using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Six
{
    public partial class Form1 : Form
    {
        string alphabet;
        string ENLang = "ABCDEFGHIJKLMNOPQRSTUVWXYZ_";
        string RULang = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ_";
        string UKLang = "АБВГҐДЕЄЖЗИІЇЙКЛМНОПРСТУФХЦЧШЩЬЮЯ_";
        string input = "ЗАЛИШАЙТЕСЬ_НА_МІСЦІ";
        string key = "БЛИСК";

        List<string> one_square = new List<string>();

        public Form1()
        {
            InitializeComponent();
            alphabet = UKLang;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rtb_input.Text = input;
            rtb_lang.Text = alphabet;
            rtb_input.Text = input;
            tb_key.Text = key;
            rb_uk.Checked = true;
        }

        private void checkForUnique()
        {
            l_status.Text = "";
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
            foreach (var ch in key)
            {
                if (!alp.Contains(ch)) throw new Exception("Key should contain only symbols from alphabet.");
            }
        }

        private void b_crypt_Click(object sender, EventArgs e)
        {
            try
            {
                l_status.Text = "";
                alphabet = rtb_lang.Text;
                input = rtb_input.Text;
                key = tb_key.Text;
                checkForUnique();
                richTextBox1.Text = cipher();
            }
            catch (Exception exc)
            {
                l_status.Text = exc.Message;
            }
        }

        private string cipher()
        {
            List<char> key_str = new List<char>();
            for(int i = 0; i < input.Length; i++)
            {
                key_str.Add(key[i%(key.Length)]);
            }
            List<List<char>> table = new List<List<char>>();
            for (int i = 0; i < key.Length; i++)
            {
                int shift = alphabet.IndexOf(key[i]);
                List<char> row = new List<char>();
                for (int j = 0; j < alphabet.Length; j++)
                {
                    row.Add(alphabet[(j + shift) % alphabet.Length]);
                }
                table.Add(row);
            }
            StringBuilder str = new StringBuilder();
            for (int c = 0; c < input.Length; c++)
            {
                int vert = alphabet.IndexOf(input[c]);
                int hor = -1;
            for (int j = 0; j < table.Count; j++)
            {
                if (table[j][0] == key_str[c])
                    hor = j;
            }
            str.Append(table[hor][vert]);
            }
            
            return str.ToString();
    
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
    }
}
