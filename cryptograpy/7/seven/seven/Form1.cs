using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seven
{
    public partial class Form1 : Form
    {
        string alphabet;
        string UKLang = "АБВГҐДЕЄЖЗИІЇЙКЛМНОПРСТУФХЦЧШЩЬЮЯ_";
        string input = "ЗАЛИШАЙТЕСЬ_НА_МІСЦІ";
        string key = "15020";
        List<int> digit_key = new List<int>();

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
            digit_key.Clear();
            foreach (var ch in key)
            {
                int digit = 0;
                if (!Int32.TryParse(""+ch, out digit ) || 
                    alphabet.Length < digit) throw new Exception("Key should contain only digits corresponding to alphabet.");
                digit_key.Add(digit);
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
            
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {

                int index = alphabet.IndexOf(input[i]);
                int shift = digit_key[i % digit_key.Count];
                str.Append(alphabet[(index+shift)%alphabet.Length]);
            }
            return str.ToString();

        }

       
    }
}
