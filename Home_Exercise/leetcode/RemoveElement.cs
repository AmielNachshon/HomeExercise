using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Exercise.leetcode
{
    class RemoveElement
    {

        public int RemoveElement2(int[] nums, int val)
        {

            int counter = 0;
            for (int i = 0; i < nums.Length; i++)
            {

                if (nums[i] == val)
                {
                    counter++;
                    nums[i] = -1;
                }
            }
            int newLength = nums.Length - counter;
            return newLength;

        }


    }
}
