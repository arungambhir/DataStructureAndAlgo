using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    class Calatan
    {
        public int findCatalan(int n)
        {
            int[] arr = new int[n + 1];

            if(n >= 0)
            arr[0] = 1;

            if(n >= 1)
            arr[1] = 1;

            if (n >= 2)
            {
                for (int i = 2; i <= n; i++)
                {
                    int sum =  0;
                    for (int j = 0, k = i-1; j < i; j++, k--)
                    {
                        sum += arr[j] * arr[k];
                    }
                    arr[i] = sum;
                }
            }
            return arr[n];
        }

    }
}
