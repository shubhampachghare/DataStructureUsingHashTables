using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    public class UC1_Permutation
    {

        public static void Permute(string S, int l, int r)
        {
            if (l == r)
                Console.WriteLine(S);
            else
            {
                for (int i = l; i <= r; i++)
                {
                    S = swap(S, l, r);
                    Permute(S, l + 1, r);
                    S = swap(S, l, i);
                }
            }
        }
        public static string swap(string a, int i, int j)
        {
            char T;
            char[] charArray = a.ToCharArray();
            T = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = T;
            string s = new string(charArray);
            return s;
        }
    }
}