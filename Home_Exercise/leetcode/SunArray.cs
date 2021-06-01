using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Exercise.leetcode
{
    class SunArray
    {
        public int MaxSubArray(int[] nums)
        {
            int[] sum = new int[nums.Length];
            int result = nums[0];
            sum[0] = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                sum[i] = Math.Max(nums[i], nums[i] + sum[i - 1]);
                result = Math.Max(sum[i], result);
            }
            return result;
        }
    }
}