using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    class EggDropPuzzle
    {
        internal int EggDropPuzzleDP(int floor, int egg)
        {
            int[,] dp = new int[floor + 1, egg + 1];
            // when floor = 0
            for (int i = 0; i <= egg; i++) { dp[0, i] = 0; }
            //when egg = 1
            for (int i = 0; i <= floor; i++) { dp[i, 1] = i; }
            //when floor = 1
            for (int i = 1; i <= egg; i++) { dp[1, i] = 1; }

            for (int i = 2; i <= floor; i++)
            {
                for (int j = 2; j <= egg; j++)
                {
                    dp[i, j] = int.MaxValue;
                    for (int k = 1; k <= i; k++)
                    {
                        //max is for worst case, (when it breaks, other don't so j is reduced in one case)
                        int subRes = Math.Max(dp[k - 1, j - 1], dp[i - k, j]);
                        if (subRes < dp[i, j])
                        {
                            dp[i, j] = subRes;
                        }
                    }
                    //+1 to include the step we performed just now.
                    dp[i, j] += 1;
                }
                
            }
            return dp[floor,egg];
        }

        internal int ParentEggDrop(int floor, int eggs)
        {
            int minFloor = int.MaxValue;
            for (int i = 1; i <= floor; i++)
            {
                int currentCount = EggDropRecrsive(i, eggs);
                if (minFloor > currentCount)
                {
                    minFloor = currentCount;
                }
            }
            return minFloor;
        }


       public int EggDropRecrsive(int floors, int eggs)
        {
            //base conditions
            if (eggs <= 1)
                return floors;
            if (floors == 1)
                return 1;
            if (floors <= 0)
                return 0;

           return Math.Max(EggDropRecrsive(floors - 1, eggs - 1),
                                         EggDropRecrsive(floors + 1, eggs)) +1;
        }

    }
}
