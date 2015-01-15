using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace crypto_one
{
    class M
    {
        protected int id;
        protected string cbItem;
        protected string descr;
        protected string inputStr;

        protected struct Alphabet
        {
            public int cryperMethod;
            public bool sameData;
            public string letters;
            public Dictionary<char, char> codePairs;
        };
        protected Alphabet currA;

        public int ID
        {
            get
            {
                return id;
            }
        }
        public string CBItemName
        {
            get 
            {
                return cbItem;
            }
        }
        public string InputStr
        {
            set
            {
                inputStr = value;
            }
            get
            {
                return inputStr;
            }
        }
        public string Descr
        {
            get
            {
                return descr;
            }
        }
        public int Cardi
        {
            get 
            {
                return currA.letters.Length;
            }
        }
        public string Letters
        {
        get
        {
            return currA.letters;
        }
        set
        {
            if (value.Length == 0)
            {
                throw new Exception("Alphabet can't be empty");
            }
            currA.letters = value;
            currA.sameData = false;
        }
        }

        protected M()
        {
            currA = new Alphabet();
            currA.cryperMethod = -1;
            currA.codePairs = new Dictionary<char, char>();
        }

        protected virtual void CryptAlphabet()
        {
            if (currA.sameData && currA.cryperMethod == id) throw new Exception();
            currA.cryperMethod = id;
            currA.sameData = true;
            currA.codePairs.Clear();
        }

        public void UncheckCryption()
        {
            currA.cryperMethod = 0;
        }

        char GetCrypted(char sym)
        {
            char val = '\0';
            if (!currA.codePairs.TryGetValue(sym, out val))
            {
                throw new Exception("Aphabets for en- and decryption aren't identical. " +
                    "Operation is forbidden.");
            }
            return val;
        }
        char GetDecrypted(char sym)
        {
            return currA.codePairs.FirstOrDefault(x => x.Value == sym).Key;
        }

        public string CryptStr(string input)
        {
            CryptAlphabet();

            StringBuilder output = new StringBuilder();
            foreach (var sym in input)
            output.Append(GetCrypted(sym));
            return output.ToString();
        }
        public string DecryptStr(string input)
        {
            CryptAlphabet();

            StringBuilder output = new StringBuilder();
            foreach (var sym in input)
                output.Append(GetDecrypted(sym));
            return output.ToString();
        }
    }
}
