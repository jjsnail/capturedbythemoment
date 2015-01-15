using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace crypto_one
{
    class MOne : M
    {
        int n;
        int mod;

        public int N
        {
            get
            {
                return n;
            }
        }
        public int Mod
        {
            get
            {
                return mod;
            }
        }
        public MOne()
        {
            base.id = 0;
            base.cbItem = "Завдання 1";
            base.inputStr = "КРИПТОГРАФІЯ";
            base.descr = "Зашифрувати повідомлення КРИПТОГРАФІЯ шифром " +
                "Цезара з ключем (m+1) mod 17, де m - номер за списком по журналу.";
            n = 8;
            mod = 17;
        }
        public void CheckParams(string nStr, string modStr)
        {
            int n_new, mod_new;
            if (!Int32.TryParse(modStr, out mod_new))
            {
                throw new Exception("Check mod");
            }
            if (!Int32.TryParse(nStr, out n_new))
            {
                throw new Exception("Check m");
            }
            if (n_new != n)
            {
                n = n_new;
                currA.sameData = false;
            }
            if (mod_new != mod)
            {
                n = n_new;
                currA.sameData = false;
            }
        }
        private char CryptLetter(char letter)
        {
            int x = base.currA.letters.IndexOf(letter);
            if (x == -1)
            {
                throw new Exception("Aphabets for en- and decryption aren't identical. " +
                    "Operation is forbidden."); 
            }
            int key = n % mod;
            int y = ((x + key) % base.Cardi + base.Cardi) % base.Cardi;
            return base.currA.letters[y];
        }

        protected override void CryptAlphabet()
        {
            try
            {
            base.CryptAlphabet();
            }
            catch (Exception) { return; }

            foreach (char sym in base.currA.letters)
                base.currA.codePairs.Add(sym, CryptLetter(sym));

        }
    }
}
