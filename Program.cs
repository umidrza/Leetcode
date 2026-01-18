using Leetcode.src.Definitions;
using Leetcode.src.Solutions.Sorting;

var solution = new InsertionSortListSolution();

var res = solution.InsertionSortList(new ListNode(4, new ListNode(2, new ListNode(1, new ListNode(3)))));
Console.WriteLine(string.Join(" ", res));
