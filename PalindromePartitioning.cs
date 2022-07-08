using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    class PalindromePartitioning
    {
        internal int PalPartDP(string s)
        {
            int n = s.Length;
            int[,] dp = new int[n, n];
            //base condition
            for (int i = 0; i < n; i++) dp[i, i] = 0;

            //gap is not clear
            for (int gap = 1; gap < n; gap++)
            {
                for (int i = 0; gap + i < n; i++)
                {
                    int j = gap + i;

                    if (IsPalindrome(s, i, j))
                        dp[i, j] = 0;
                    else
                        dp[i, j] = int.MaxValue;

                    for (int k = i; k < j; k++)
                    {
                        dp[i, j] = Math.Min(dp[i, j], dp[i, k] + dp[k + 1, j] + 1);
                    }
                
                }
            
            }
            return dp[0, n-1];
        }
        internal int PalPartRec(string s, int i, int j)
        {
            if (IsPalindrome(s,i,j)) return 0;
            int res = int.MaxValue;
            for (int k = i; k < j; k++)
            {
                res = Math.Min(res, PalPartRec(s, i, k) + PalPartRec(s, k+1,j)+1);
            }

            return res;
        }

        private bool IsPalindrome(string s, int i, int j)
        {
            char[] str = s.ToCharArray();
            for (; i <= j; i++, j--)
            {
                if (s[i] != s[j])
                    return false;
            }

            return true;
        }
    }
}
