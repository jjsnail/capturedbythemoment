using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace crypto_one
{
    class MThree : M
    {
        public string keyWord;
        int k;
        public int K
        {
            get
            {
                return k;
            }
        }
        public string KeyWord
        {
            get
            {
                return keyWord;
            }
        }
        public MThree()
        {
            base.id = 2;
            base.cbItem = "Завдання 3";
            base.inputStr = "ПРАВИЛО";
            base.descr = "Дана система Цезаря з ключовим словом. " +
                "Алфавіт (російський чи український) обрати самостійно. " +
                "Зашифрувати повідомлення надане в таблиці 1. Ключ також надано " +
                " в таблиці. Ключове слово ФОРЕЛЬ.";
            keyWord = "ФОРЕЛЬ";
            k = 14;
        }

        private void FindLetter(char letter)
        {
            int x = base.currA.letters.IndexOf(letter);
            if (x == -1)
            {
                throw new Exception("Keyword doesn't belong to current alphabet. " +
                    "Operation is forbidden.");
            }
        }

        protected override void CryptAlphabet()
        {
            try
            {
            base.CryptAlphabet();
            }
            catch (Exception) { return; }
//check if keyword belongs to current alphabet & have same symbols
            List<char> key = new List<char>();
            foreach (var letter in keyWord)
            {
                FindLetter(letter);
                if (!key.Contains(letter)) key.Add(letter);
            }
            for (int i = 0; i < key.Count; i++)
            {
                base.currA.codePairs.Add(base.currA.letters[(i+k) % base.Cardi], 
                    key[i]);
            }
            for (int i = 0, j = k + key.Count; i < base.Cardi; i++)
            {
                if (!key.Contains(base.currA.letters[i]))
                {
                    base.currA.codePairs.Add(base.currA.letters[(j) % base.Cardi],
                    base.currA.letters[i]);
                    j++;
                }
            }
        }
        public void CheckParams(string kStr)
        {
            int k_new;
            if (!Int32.TryParse(kStr, out k_new))
            {
                throw new Exception("Check k");
            }
            if (k_new != k)
            {
                k = k_new;
                currA.sameData = false;
            }
        }
    }
}
