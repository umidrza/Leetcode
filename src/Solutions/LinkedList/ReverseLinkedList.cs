using Leetcode.src.Definitions;

namespace Leetcode.src.Solutions.LinkedList;

// https://leetcode.com/problems/reverse-linked-list
public class ReverseLinkedList
{
    public ListNode ReverseList(ListNode head)
    {
        ListNode dummy = null;

        while (head != null)
        {
            ListNode next = head.next;
            head.next = dummy;
            dummy = head;
            head = next;
        }

        return dummy;
    }
}
