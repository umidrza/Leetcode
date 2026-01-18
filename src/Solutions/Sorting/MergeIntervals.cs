namespace Leetcode.src.Solutions.Sorting;

// https://leetcode.com/problems/merge-intervals
public class MergeIntervals
{
    public int[][] Merge(int[][] intervals)
    {
        System.Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

        List<int[]> res = new List<int[]>();
        res.Add(intervals[0]);

        for (int i = 1; i < intervals.Length; i++)
        {
            int[] last = res[^1];
            int[] current = intervals[i];

            if (current[0] <= last[1])
                last[1] = Math.Max(last[1], current[1]);
            else
                res.Add(current);
        }

        return res.ToArray();
    }
}
