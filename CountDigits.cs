using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    class CountDigits
    {
        internal int countDigits(int x)
        {
            string s = x.ToString();
            return s.Length;
        
        }

        internal int countDigitsLog(int x)
        {
            if (x == 0) return 0;
            return Convert.ToInt32(Math.Floor(Math.Log10(x) + 1));

        }
    }
}
