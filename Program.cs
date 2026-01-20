using Leetcode.src.Solutions.BinarySearch;
using Leetcode.src.Solutions.DivideAndConquer;

var solution = new ConstructBinaryTreeFromInorderAndPostorderTraversal();

var res = solution.BuildTree([9, 3, 15, 20, 7], [9, 15, 7, 20, 3]);
Console.WriteLine(string.Join(" ", res));
