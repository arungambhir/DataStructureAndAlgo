using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    class LCS
    {
        public int LongestCommonSubsequence(string text1, string text2)
        {

            if (text1.Equals(text2))
                return text1.Length;

            int M = text1.Length;
            int N = text2.Length;
            char[] S1 = text1.ToCharArray();
            char[] S2 = text2.ToCharArray();

            int[,] memo = new int[M + 1, N + 1];

            for (int i = 0; i <= M; i++)
            {
                for (int j = 0; j <= N; j++)
                {
                    memo[i, j] = -1;
                }
            }

            return lcs(S1, S2, M, N, memo);

        }

        public int lcs(char[] S1, char[] S2, int M, int N, int[,] memo)
        {
            if (memo[M, N] != -1)
                return memo[M, N];

            if (M == 0 || N == 0)
                return 0;

            if (S1[M - 1] == S2[N - 1])
            {
                memo[M, N] = 1 + lcs(S1, S2, M - 1, N - 1, memo);
            }
            else
            {
                memo[M, N] = Max(lcs(S1, S2, M, N - 1, memo), lcs(S1, S2, M - 1, N, memo));
            }

            return memo[M, N];
        }

        private int Max(int v1, int v2)
        {
            if (v1 > v2)
                return v1;
            else
                return v2;

        }

        public int longestCommonSeq(int x, int y, string s1, string s2)
        {
            int[,] dp = new int[x + 1, y + 1];

            //for (int i = 0; i < x; i++) dp[i, 0] = 0;
            //for (int i = 0; i < y; i++) dp[0, i] = 0;

            for (int i = 1; i <= x; i++)
            {

                for (int j = 1; j <= y; j++)
                {// Issue is with duplicate charaters, logic won't work.
                    dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                    if (s1.Substring(i-1, 1).Equals(s2.Substring(j-1, 1)))
                        dp[i, j] += 1;
                }

            }
            return dp[x, y];
        }
    }

}
