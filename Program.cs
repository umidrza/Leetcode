
using Leetcode.src.Solutions.SlidingWindow;

var solution = new NumberOfSubArraysOfSizeKAndAverageGreaterThanOrEqualToThreshold();

var res = solution.NumOfSubarrays([2, 2, 2, 2, 5, 5, 5, 8], 3, 4);
Console.WriteLine($"[{ string.Join(" ", res)}]");