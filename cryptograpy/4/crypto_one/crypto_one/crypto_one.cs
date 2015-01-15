using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace crypto_one
{
    public partial class crypto_one : Form
    {
        M currM;
        int currMNumber;
        M[] ms = new M[1];
        bool[] mflags = new bool[]{true};
        private string rtb_lang_text;

        public crypto_one()
        {
            InitializeComponent();

            ms[0] = new MOne();
        }

        void SwitchToM(int i, bool apply)
        {
            if (!apply) return;

            currMNumber = i;
            currM = ms[i];
            ms[i].Letters = rtb_lang_text;
            rtb_input.Text = currM.InputStr;
            rtb_descr.Text = currM.Descr;
            if (mflags[i])
            {
                tb_key.Text = ((MOne)currM).Key;
                mflags[i] = false;
            }
        }

        void SwitchToLang(string lang)
        {
            switch (lang)
            {
                case "UK":
                    rb_uk.Checked = true;
                break;
                case "RU":
                    rb_ru.Checked = true;
                break;
                case "EN":
                    rb_en.Checked = true;
                break;
                default:
                throw new Exception("Uknown language");
            }
        }

        private void crypto_one_Load(object sender, EventArgs e)
        {
//fill visual part for def lang
            SwitchToLang("UK");
//fill visual part for def meth
            SwitchToM(0, true);
        }

        private void cb_method_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(var m in ms)
            {
                if (((string)((ComboBox)sender).SelectedItem).CompareTo(m.CBItemName) == 0)
                {
                    rtb_descr.Text = m.Descr;
                    SwitchToM(m.ID, true);
                    break;
                }
            }
        }
       
        private void rb_lang_CheckedChanged(object sender, EventArgs e)
        {
            switch (((RadioButton)sender).Text)
            {
                case "UK":
                    rtb_lang_text = Voc.UKLang;
                    break;
                case "RU":
                    rtb_lang_text = Voc.RULang;
                    break;
                case "EN":
                    rtb_lang_text = Voc.ENLang;
                    break;
                default:
                    throw new Exception("Uknown language");
            }
            rtb_lang.Text = rtb_lang_text;
            tb_card.Text = rtb_lang_text.Length.ToString();
            if (currM != null)
                currM.Letters = rtb_lang_text;
        }

        private void rtb_lang_Enter(object sender, EventArgs e)
        {
            rtb_lang_text = rtb_lang.Text;
        }

        private void b_lang_TextChanged(object sender, EventArgs e)
        {
            if (rtb_lang.Text.CompareTo(rtb_lang_text) != 0)
            {
                b_lang.Visible = true;
                b_cancel.Visible = true;
                b_crypt.Enabled = false;
                b_decrypt.Enabled = false;
                tb_card.Text = rtb_lang.Text.Length.ToString();
            }
        }

        private void b_lang_Click(object sender, EventArgs e)
        {
            try
            {
                currM.Letters = rtb_lang.Text;
                b_cancel.Visible = false;
                b_lang.Visible = false;
                b_crypt.Enabled = true;
                b_decrypt.Enabled = true;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void b_cancel_Click(object sender, EventArgs e)
        {
            rtb_lang.Text = rtb_lang_text;
            b_cancel.Visible = false;
            b_lang.Visible = false;
            b_crypt.Enabled = true;
            b_decrypt.Enabled = true;
            tb_card.Text = rtb_lang_text.Length.ToString();
        }

        private void b_crypt_Click(object sender, EventArgs e)
        {
            try
            {
                if (currMNumber == 0)
                    ((MOne)currM).CheckParams(tb_key.Text);
                tb_key.Text = ((MOne)currM).Key;
                currM.InputStr = rtb_input.Text;
                rtb_output.Text = currM.CryptStr(rtb_input.Text);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                rtb_output.Text = "";
            }
        }

        private void b_decrypt_Click(object sender, EventArgs e)
        {
            try
            {
                if (currMNumber == 0)
                    ((MOne)currM).CheckParams(tb_key.Text);
                tb_key.Text = ((MOne)currM).Key;
                rtb_input.Text = currM.DecryptStr(rtb_output.Text);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                rtb_output.Text = "";
            }
        }
    }
}
