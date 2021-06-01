using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Exercise.leetcode
{
    class LastWord
    {
        public int LengthOfLastWord(string s)
        {
            if (s.Length == null)
                return  0;
            int lastWordSize = 0;
            //char[] arr = s.ToCharArray();
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] != ' ')
                    lastWordSize++;

                else
                    return lastWordSize;


            }
            return lastWordSize;

        }
    }
}
