using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    class FibonacciTopDown
    {
        //Function to find the nth fibonacci number using bottom-up approach.
        public long findNthFibonacci(int number, long[] dp)
        {
            //base case
            if (number == 0 || number == 1)
            {
                dp[number] = number;
            }

            //actual logic
            if (dp[number] == 0 && number > 0)
            {
                dp[number] = findNthFibonacci(number - 1, dp) + findNthFibonacci(number - 2, dp);
            }

            //return value
            return dp[number];
        }

    }
}
