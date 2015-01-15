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
        M[] ms = new M[3];
        bool[] mflags = new bool[]{true, true, true};
        Panel[] mpanels = new Panel[3];
        private string rtb_lang_text;

        public crypto_one()
        {
            InitializeComponent();
            mpanels[0] = p_one;
            mpanels[1] = p_two;
            mpanels[2] = p_three;

            ms[0] = new MOne();
            ms[1] = new MTwo();
            ms[2] = new MThree();
            foreach (var m in ms)
            {
                cb_method.Items.Add(m.CBItemName);
            }
        }

        void SwitchToM(int i, bool apply)
        {
            if (!apply) return;

            currMNumber = i;
            foreach (var p in mpanels)
            {
                p.Visible = false;
            }
            mpanels[i].Visible = true;
            currM = ms[i];
            ms[i].Letters = rtb_lang_text;
            rtb_input.Text = currM.InputStr;
            rtb_descr.Text = currM.Descr;
            if (mflags[i])
            {
                if (i == 0)
                {
                    tb_m.Text = ((MOne)currM).N.ToString();
                    tb_mod.Text = ((MOne)currM).Mod.ToString();
                }
                else if (i == 1)
                {
                    tb_a.Text = ((MTwo)currM).A.ToString();
                    tb_b.Text = ((MTwo)currM).B.ToString();
                }
                else
                {
                    tb_key_word.Text = ((MThree)currM).KeyWord;
                    tb_k.Text = ((MThree)currM).K.ToString();
                }
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
            cb_method.SelectedIndex = 0;
            SwitchToM(0, true);
            SwitchToM(1, false);
            SwitchToM(2, false);

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
                    ((MOne)currM).CheckParams(tb_m.Text, tb_mod.Text);
                else if (currMNumber == 1)
                    ((MTwo)currM).CheckParams(tb_a.Text, tb_b.Text);
                else
                    ((MThree)currM).CheckParams(tb_k.Text);

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
                    ((MOne)currM).CheckParams(tb_m.Text, tb_mod.Text);
                else if (currMNumber == 1)
                    ((MTwo)currM).CheckParams(tb_a.Text, tb_b.Text);
                else
                    ((MThree)currM).CheckParams(tb_k.Text);

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
