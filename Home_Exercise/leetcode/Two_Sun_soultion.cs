using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Exercise.leetcode
{
    class Two_Sun_soultion
    {

        public int[] TwoSumArrays(int[] array, int target)
        {
            int[] arr = new int[2];
            if (array.Length < 2)
                return null;
            else
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[i] + array[j] == target)
                        {
                            arr[0] = i;
                            arr[1] = j;
                        }

                    }


                }

            return arr;



        }


    }
}
