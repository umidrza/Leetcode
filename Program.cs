using Leetcode.src.Definitions;
using Leetcode.src.Solutions.Sorting;

var solution = new MergeKSortedLists();

var res = solution.MergeKLists([new ListNode(1, new ListNode(4, new ListNode(5))), new ListNode(1, new ListNode(3, new ListNode(4))), new ListNode(2, new ListNode(6))]);
Console.WriteLine(string.Join(" ", res));
