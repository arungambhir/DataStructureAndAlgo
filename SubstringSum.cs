using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    class SubstringSum
    {
        public long sumSubstrings(string s)
        {
            int n = s.Length;
            char[] arr = s.ToCharArray(); 
            long sum = 0;
            long lastSum = arr[0] - '0' % 1000000007;
            long final = lastSum;
            
            for (int i = 1; i < n; i++)
            {
                sum = ((i + 1) * (arr[i] - '0') + 10 * lastSum) % 1000000007;
                lastSum = sum;
                final += sum;
            }

            return final % 1000000007;
        }
    }
}
