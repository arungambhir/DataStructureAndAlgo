using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    class FibonacciBottomUp
    {
        //Function to find the nth fibonacci number using bottom-up approach.
        public long findNthFibonacci(int number)
        {
            long retVal = 0;
            if (number >= 2)
            {
                long[] arr = new long[number];
                arr[0] = 1;
                arr[1] = 1;

                for (int i = 2; i < number; i++)
                {
                    arr[i] = arr[i - 1] + arr[i - 2];

                }
                retVal = arr[number - 1];
            }
            else if (number == 1)
            {
                retVal = 1;
            }

            return retVal;
            // your code here
        }

        //public long countWays(int n)
        //{
        //    //we use similar algorithm as Fibonacci series to find the
        //    //number of ways in which frog can reach the top.

        //    long mod = 1000000007;

        //    //base cases
        //    if (n == 1) return 1;
        //    if (n == 2) return 2;
        //    if (n == 3) return 4;

        //    //initializing base values.
        //    long a = 1, b = 2, c = 4, temp;

        //    for (int i = 4; i <= n; i++)
        //    {
        //        temp = (a + b + c) % mod;
        //        //updating a as b and b as c and c as temp (sum of a, b and c).
        //        a = b;
        //        b = c;
        //        c = temp;
        //    }
        //    //returning the result.
        //    return c;
        //}
        public long countWays(int n)
        {

            long retVal = 0;
            if (n >= 2)
            {
                long[] arr = new long[n + 1];
                arr[0] = 1;
                arr[1] = 1;
                arr[2] = 2;
                for (int i = 3; i <= n; i++)
                {
                    long temp = arr[i - 1] + arr[i - 2] + arr[i - 3];
                    arr[i] = (arr[i - 1] + arr[i - 2] + arr[i - 3]) % 1000000007 ;
                    long temp1 = arr[i];
                }
                retVal = arr[n];
            }
            else
            {
                retVal = 1;
            }

            return retVal;


        }

    }
}
