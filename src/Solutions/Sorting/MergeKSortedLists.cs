using Leetcode.src.Definitions;

namespace Leetcode.src.Solutions.Sorting;

// https://leetcode.com/problems/merge-k-sorted-lists
public class MergeKSortedLists
{
    public ListNode MergeKLists(ListNode[] lists)
    {
        ListNode res = new ListNode();

        for (int i = 0; i < lists.Length; i++)
        {
            ListNode head = res;
            ListNode curr = lists[i];

            while (curr != null)
            {
                if (head.next == null)
                {
                    head.next = curr;
                    break;
                }

                ListNode headNext = head.next;
                ListNode currNext = curr.next;

                if (head.next.val > curr.val)
                {
                    head.next = curr;
                    curr.next = headNext;
                    curr = currNext;

                }
                else
                {
                    head = headNext;
                }
            }
        }

        return res.next;
    }
}
