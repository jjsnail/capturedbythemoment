using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crypto_twelve
{
    class InverseA
    {
        static string BinByBin(string one, string two)
        {
            List<string> terms = new List<string>();
            for (int i = 0; i < one.Length; i++)
            {
                if (one[i] == '1')
                {
                    terms.Add(two.Insert(two.Length, new string('0', one.Length - i - 1)));
                }
            }
            string summ = "0";
            foreach (var part in terms)
            {
                summ = BinPlusBin(summ, part);
            }
            return summ;
        }
        internal static string BinPlusBin(string one, string two)
        {
            int l1 = one.Length;
            int l2 = two.Length;
            for(int i = 0; i < l1- l2; i++)
                    two = two.Insert(0, "0");
            for(int i = 0; i < l2 - l1; i++)
                    one = one.Insert(0, "0");

            StringBuilder res = new StringBuilder();
            for (int i = 0; i < one.Length; i++)
            {
                if (one[i] == two[i])
                    res.Append("0");
                else
                    res.Append("1");
            }
            while (res.Length > 0 && res[0] == '0')
                res = res.Remove(0, 1);
            return res.ToString();
        }

        static string FromNumsToBins(List<int> nums)
        {
//TO DO check if nums hasn't same elements and order of digits is correct
            StringBuilder bins = new StringBuilder();
            for (int i = 0; i <= nums[0]; i++)
                bins.Append("0");
            foreach (var digit in nums)
                bins[bins.Length - 1 - digit] = '1';
            return bins.ToString();
        }
        private static string[] Divide(string up, string down)
        {
            string qs = "0";
 //trim all forward zeros
            while (down.Length > 0 && down.First() == '0')
                down = down.Remove(0, 1);
            StringBuilder left = new StringBuilder();
            for (; ; )
            {
                string temp_down = down;
                left.Clear();
                while (up.Length > 1 && up.First() == '0')
                    up = up.Remove(0, 1);
                //translate into powers
                int digitsCount = up.Length - temp_down.Length;
                if (digitsCount < 0)
                    return new string[] {qs, up.ToString() };
                string forsum = "1";
                for(int i = 0; i < digitsCount; i++)
                forsum += "0";
                qs = BinPlusBin(qs, forsum);
                //multiply denominator to numerators's pow
                for (int i = 0; i < digitsCount; i++)
                {
                    temp_down += "0";
                }
                //stay only different values in digits - that's the left
                for (int i = 0; i < up.Length; i++)
                {
                    if (up[i] == temp_down[i])
                        left.Append("0");
                    else
                        left.Append("1");
                }
                up = left.ToString();
            }
        }

        internal static string Get(string poly, string bin)
        {
            List<string> qAs = new List<string>();
            qAs.Add("1");
            List<string> As = new List<string>();
            As.Add("0");
            As.Add("1");
            string[] q = new string[]{ "", ""};
            for (;;)
            {
                
                q = Divide(poly, bin);
                qAs.Add(q[0]);
                string multi = BinByBin(qAs.Last(), As.Last());
                string summ = BinPlusBin(multi, As[As.Count - 2]);
                As.Add(summ);
                if (q[1] == "1")
                {
                //    qAs.Add(bin);
                    break;
                }
                poly = bin;
                bin = q[1];
                
            }
            return As.Last();
        }
    }
}
