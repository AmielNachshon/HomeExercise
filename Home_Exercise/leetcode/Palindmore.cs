using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Exercise.leetcode
{
    class Palindmore
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0 || x % 10 == 0 && x != 0)
            {
                return false;
            }

            int rev = 0;
            while (x > rev)
            {
                rev = rev * 10 + x % 10;
                x = x / 10;


            }

            return (rev == x) || (x == rev / 10);



        }

      
    }
}
