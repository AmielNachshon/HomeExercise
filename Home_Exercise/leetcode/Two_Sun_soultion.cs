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

        public int[] TwoSumArraysUsingDictionary (int[] array, int target)
        {
            Dictionary<int, int> DictionaryOfTwoSums = new Dictionary<int, int>(); 
            for (int i = 0; i < array.Length; i++)
            {
                DictionaryOfTwoSums.Add(i, array[i]);

            }

            for (int i = 0; i < array.Length;i++ )
            {
                int complement = target - array[i];

                if (DictionaryOfTwoSums.ContainsValue(complement))
                {

                    int[] arr = { i,DictionaryOfTwoSums.ElementAt(complement).Key};
                    return arr;
                }

            }
            

        }



    }
}
