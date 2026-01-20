using Leetcode.src.Definitions;

namespace Leetcode.src.Solutions.TwoPointers;

// https://leetcode.com/problems/linked-list-cycle
public class LinkedListCycle
{
    public bool HasCycle(ListNode head)
    {
        ListNode slow = head;
        ListNode fast = head;

        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;

            if (slow == fast) return true;
        }

        return false;
    }
}
