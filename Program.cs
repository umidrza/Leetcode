using Leetcode.src.Solutions.BFS;

var solution = new BusRoutes();

var res = solution.NumBusesToDestination([[1, 2, 7], [3, 6, 7]], 1, 6);
Console.WriteLine($"[{ string.Join(" ", res)}]");