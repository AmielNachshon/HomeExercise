using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Exercise.leetcode
{
    class Revers_integer
    {
        public int reverseInteger (int number)
        {
            int revesreNum = 0;

            while (number != 0)
            {
                revesreNum = revesreNum * 10 + number % 10;
                number= number / 10;



            }

            return revesreNum;

        }


    }
}
