using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    class MinimumJumps
    {
        /*
         We will keep 3 variables:
            jumps = jumps taken, this will be our answer
            maxrange = maximum range up to which we can jump
            steps = to store steps that we can take for a particular jump
         */

        public int minJumps(int[] arr)
        {
            if (arr.Length <= 1)
                return 0;

            // Return -1 if not
            // possible to jump
            if (arr[0] == 0)
                return -1;

            // initialization
            int maxReach = arr[0];
            int step = arr[0];
            int jump = 1;

            // Start traversing array
            for (int i = 1; i < arr.Length; i++)
            {
                // Check if we have reached
                // the end of the array
                if (i == arr.Length - 1)
                    return jump;

                // updating maxReach
                maxReach = Math.Max(maxReach, i + arr[i]);

                // we use a step to get
                // to the current index
                step--;

                // If no further steps left
                if (step == 0)
                {
                    // we must have used a jump
                    jump++;

                    // Check if the current index/position
                    // or lesser index is the maximum reach
                    // point from the previous indexes
                    if (i >= maxReach)
                        return -1;

                    // re-initialize the steps to
                    // the amount of steps to reach
                    // maxReach from position i.
                    step = maxReach - i;
                }
            }

            return -1;
        }
        public int minimumJumps(int[] arr, int n)
        {
            //Your code here
            int[] dp = new int[n];

            dp[0] = 0;

            for (int i = 1; i < n; i++) dp[i] = int.MaxValue;

            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[j] + j >= i)
                    {
                        // check if that j value is reachable or not.
                        if(dp[j] != int.MaxValue)
                        dp[i] = Math.Min(dp[i], dp[j] + 1);

                    }

                }


            }
            return dp[n - 1];
        }
    }
}
