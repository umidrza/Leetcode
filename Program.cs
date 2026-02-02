using Leetcode.src.Solutions.Backtracking;
using Leetcode.src.Solutions.UnionFind;

var solution = new ProcessRestrictedFriendRequests();

var res = solution.FriendRequests(5, [[0, 1], [1, 2], [2, 3]], [[0, 4], [1, 2], [3, 1], [3, 4]]);
Console.WriteLine($"[{ string.Join(" ", res)}]");