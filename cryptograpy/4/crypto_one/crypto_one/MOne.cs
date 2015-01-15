using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace crypto_one
{
    class MOne : M
    {
        const int Digits = 6;
        string key;

        public string Key
        {
            get
            {
                return key;
            }
        }
        public MOne()
        {
            base.id = 0;
            base.cbItem = "Завдання 1";
            base.inputStr = "НАТ";
            base.descr = "Зашифрувати перші три букви свого  імені," +
            "використавши шифр одноразового блокноту з ключем 110000 011110 010100." +
            "Букви імені для цього спочатку надати в двійковій формі" +
            "( кожен блок з шести цифр є номером відповідної букви у двійковому запису).";
            key = "110000 011110 010100";
        }
        public void CheckParams(string keyStr)
        {
            StringBuilder key_new = new StringBuilder();
            int i = 0;
            foreach(var sym in keyStr)
            {
                if (sym != ' ' && sym != '0' && sym != '1' )
                    throw new Exception("Key doesn't have binary format!");

                if (sym == ' ') continue;

                if (i == Digits)
                {
                i = 0;
                key_new.Append(' ');
                }
                key_new.Append(sym);
                i++;
            }
            if (i != Digits) throw new Exception("Key doesn't have enought digits");
            if (key_new.ToString().CompareTo(key) != 0)
            {
                key = key_new.ToString();
                currA.sameData = false;
            }
        }
        private char CryptLetter(char letter, string binKey)
        {
            int x = base.currA.letters.IndexOf(letter);
            if (x == -1)
            {
                throw new Exception("Aphabets for en- and decryption aren't identical. " +
                    "Operation is forbidden."); 
            }
            return currA.letters[(x ^ DecFromBin(binKey)) % base.Cardi];
        }

        protected override void CryptAlphabet()
        {
            try
            {
            base.CryptAlphabet();
            }
            catch (Exception) { return; }
            string[] parts = key.Split(' ');
            for (int i = 0; i < parts.Length; i++)
            {
                base.currA.codePairs.Add(inputStr[i], CryptLetter(inputStr[i], parts[i]));
            }
        }

        int DecFromBin(string bin6view)
        {
            int dec = 0;
            for (int i = 0, j = Digits - 1; i < Digits; i++, j--)
            {
                dec += bin6view[j] == '1' ? (int)Math.Pow(2, i) : 0;
            }
            return dec;
        }

        int BinFromDec(string bin6view)
        {
            int dec = 0;
            for (int i = 0, j = Digits - 1; i < Digits; i++, j--)
            {
                dec += bin6view[j] == '1' ? (int)Math.Pow(2, i) : 0;
            }
            return dec;
        }

        //string XOR(string bin1, string bin2)
        //{
        //    StringBuilder bin = new StringBuilder();
        //    if (bin1.Length != bin2.Length) throw new Exception("For XOR operation binary formats has to have same digits's amount");
        //    for (int i = 0; i < bin1.Length; i++)
        //    {
        //        bin.Append((bin1[i] == bin2[i]) ? '0' : '1');
        //    }
        //    return bin.ToString();
        //}
    }
}
