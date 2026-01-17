using Leetcode.LinkedList;

var solution = new ReverseLinkedList();

var res = solution.ReverseList(new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5))))));
Console.WriteLine(string.Join(" ", res));
