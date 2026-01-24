using Leetcode.src.Solutions.Recursion;

var solution = new DecodeStringSolution();

var res = solution.DecodeString("3[a]2[bc]");
Console.WriteLine($"[{ string.Join(" ", res)}]");