using Leetcode.src.Solutions.Graph;

var solution = new MaximumPathQualityOfAGraph();

var res = solution.MaximalPathQuality([0, 32, 10, 43], [[0, 1, 10], [1, 2, 15], [0, 3, 10]], 49);
Console.WriteLine($"[{ string.Join(" ", res)}]");