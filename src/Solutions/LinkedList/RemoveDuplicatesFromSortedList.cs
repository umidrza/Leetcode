using Leetcode.src.Definitions;

namespace Leetcode.src.Solutions.LinkedList;

// https://leetcode.com/problems/remove-duplicates-from-sorted-list
public class RemoveDuplicatesFromSortedList
{
    public ListNode DeleteDuplicates(ListNode head)
    {
        if (head == null) return null;
        ListNode dummy = head;

        while (head.next != null)
        {
            if (head.val == head.next.val)
                head.next = head.next.next;
            else
                head = head.next;
        }

        return dummy;
    }
}
