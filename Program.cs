using Leetcode.src.Solutions.Backtracking;

var solution = new AllPathsFromSourceToTarget();

var res = solution.AllPathsSourceTarget([[1, 2], [3], [3], []]);
Console.WriteLine($"[{ string.Join(" ", res)}]");