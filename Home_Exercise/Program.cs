using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Home_Exercise.leetcode;

namespace Home_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> l1 = new LinkedList<int>();
            LinkedList<int> l2 = new LinkedList<int>();

            int[] array1 = new int[] {23 , 3,5,6 };
            MaximumProductExe max = new MaximumProductExe();
            max.MaximumProduct(array1);
            Console.WriteLine("For array : ");

            foreach (int item in array1)
            {
                Console.Write(item + ",");
                
            }
            Console.WriteLine("");
            Console.WriteLine("============================");
            Console.WriteLine("Maximun product equals to: " +  max.MaximumProduct(array1));

            SearchInsertExc Si = new SearchInsertExc();
            Console.WriteLine(Si.SearchInsert(array1, 5));

            LastWord word = new LastWord();
            word.LengthOfLastWord("H");


            Console.ReadLine();

            l1.AddLast(1);
            l1.AddLast(3);
            l1.AddLast(5);
            l2.AddLast(2);
            l2.AddLast(4);
            l2.AddLast(6);

            

        }
    }
}
