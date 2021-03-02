using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Exercise.leetcode
{
    class longestCommonPrefix
    {

        public string longestCommonPrefixResult (string [] strs)
        {
            if (strs.Length == 0)
                return "";
            for (int i = 0; i < strs[0].Length; i ++ )
            {

                for (int j = 1; j < strs.Length; j ++)
                {
                    if (i == strs[j].Length || strs[0][i] != strs[j][i])
                        return strs[0].Substring(0, i);


                }


            }
            return strs[0];


        }


    }
}

public class Solution

{

    public string longestCommonPrefix(string[] strs)
    {
        if (strs.Length == 0)
            return "";

        for (int i = 0; i < strs[0].Length; i++)
        {

            for (int j = 1; j < strs.Length; j++)
            {
                if (i == strs[j].Length || strs[0][i] != strs[j][i])
                    return strs[0].Substring(0, i);
            }


        }
        return strs[0];
    }


}
