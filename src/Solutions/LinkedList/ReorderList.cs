using Leetcode.src.Definitions;

namespace Leetcode.src.Solutions.LinkedList;

// https://leetcode.com/problems/reorder-list
public class ReorderListSolution
{
    public void ReorderList(ListNode head)
    {
        if (head == null || head.next == null)
            return;

        // 1. Find middle
        ListNode slow = head;
        ListNode fast = head;

        while (fast.next != null && fast.next.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        // 2. Reverse second half
        ListNode second = ReverseList(slow.next);
        slow.next = null; // split the list

        // 3. Merge two halves
        ListNode first = head;

        while (second != null)
        {
            ListNode temp1 = first.next;
            ListNode temp2 = second.next;

            first.next = second;
            second.next = temp1;

            first = temp1;
            second = temp2;
        }
    }

    private ListNode ReverseList(ListNode head)
    {
        ListNode prev = null;

        while (head != null)
        {
            ListNode next = head.next;
            head.next = prev;
            prev = head;
            head = next;
        }

        return prev;
    }
}
