using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace crypto_one
{
    class MTwo : M
    {
        int a, b;
        public int A
        {
            set
            {
                a = value;
            }
            get 
            {
                return a;
            }
        }
        public int B
        {
            set
            {
                b = value;
            }
            get
            {
                return b;
            }
        }

        public MTwo()
        {
            base.id = 1;
            base.cbItem = "Завдання 2";
            base.inputStr = "КРИПТОГРАФІЯ";
            base.descr = "Зашифрувати повідомлення КРИПТОГРАФІЯ афінною " +
                "системою підстановок Цезара (at+b) mod m, де 1<a, b<m, НОД(a,m)=1 в українському чи " +
                "російському  алфавіті. Параметри a та b обрати самостійно, m - потужність алфавіту.";
            a = 3;
            b = 4;    
        }
        public void CheckParams(string aStr, string bStr)
        {
            int a_new, b_new;
            if (!(Int32.TryParse(aStr, out a_new) && Int32.TryParse(bStr, out b_new) &&
    (1 < a_new && b_new < base.currA.letters.Length && GCD(a_new, base.currA.letters.Length) == 1)))
            {
                throw new Exception("Check a & b");
            }
            if (a_new != a)
            {
                a = a_new;
                currA.sameData = false;
            }
            if (b_new != b)
            {
                b = b_new;
                if (currA.sameData)
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
            int y = (a * x + b) % base.Cardi;
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

        private int GCD(int n, int k)
        {
            if (((k > n) ? k : n) % ((k > n) ? n : k) != 0)
            {
                while (n != k)
                {
                    int diff = Math.Abs(n - k);
                    if (n > k)
                        n = diff;
                    else
                        k = diff;
                }
            }
            return (k > n) ? n : k;
        }
    }
}
