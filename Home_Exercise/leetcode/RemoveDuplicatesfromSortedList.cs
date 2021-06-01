using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Exercise.leetcode
{
    class RemoveDuplicatesfromSortedList
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            ListNode toReturn = head;
            if (head.next == null)
                return head;

            while (head.next != null )
            {
                while ( (head.next).val == head.val)
                {
                    head.next = (head.next).next;
                    (head.next).next = null;
                   

                }
                head = head.next;                            

            }
            return toReturn;

        }
    }



}

