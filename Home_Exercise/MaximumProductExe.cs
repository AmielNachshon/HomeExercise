using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Exercise
{
    class MaximumProductExe
    {
        public int MaximumProduct(int[] arr)

        {
            int maxSum = -2000 ;
            int temp = -2000;
            for (int i = 0; i < arr.Length; i++)
            {

                for (int j = i+2; j < arr.Length; j++)
                {

                    temp = arr[i] * arr[j - 1] * arr[j];

                    if (temp > maxSum)
                        maxSum = temp;
                }


            }


            return maxSum; 
        }
        

    }
}
