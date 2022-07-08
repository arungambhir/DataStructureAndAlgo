using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    class KnapsackDP
    {
        //val ={10,40,30,50} , W = 10, wt = {5,4,6,3}, n = 4
        int Knapsack(int W, int[] wt, int[] val, int n)
        {
            int[,] dp = new int[n + 1, W + 1];
            /*
            for loop n = 0 then dp =
            
            if(wt[i] > W[J]  ) then 0
            else -dp[i,j] = max(dp[i,j-1])

            */
            return 0;
        }
    }
}
