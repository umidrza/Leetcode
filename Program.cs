using Leetcode.src.Solutions.Graph;

var solution = new AddEdgesToMakeDegreesOfAllNodesEven();

var res = solution.IsPossible(5, [[1, 2], [2, 3], [3, 4], [4, 2], [1, 4], [2, 5]]);
Console.WriteLine($"[{ string.Join(" ", res)}]");