using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Exercise.leetcode
{
    class PlusOne
    {
        public int[] PlusOnefunc(int[] digits)
        {
            for (int i = digits.Length - 1 ; i >=  0; i-- )
            {
                if (digits[i] < 9)
                {
                    digits[i]++;
                    return digits;

                }

                digits[i] = 0;
                    


            }
            int[] newArr = new int[digits.Length+1];
            newArr[0] = 1;
            return newArr;

        }


    }
}
