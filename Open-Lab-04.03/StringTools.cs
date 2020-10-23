using System;
using System.Linq;

namespace Open_Lab_04._03
{
    public class StringTools
    {
        public string RemoveFirstLast(string original)
        {
            string a = "";
            int L = original.Length;
            if(L == 1)
            {
                return original;
            }
            for (int i = 1; i < L - 1; i++)
            {
                a = a + original[i];
            }
            return a;
        }
    }
}
