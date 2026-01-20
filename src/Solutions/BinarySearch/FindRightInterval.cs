namespace Leetcode.src.Solutions.BinarySearch;

// https://leetcode.com/problems/find-right-interval
public class FindRightIntervalSolution
{
    public int[] FindRightInterval(int[][] intervals)
    {
        int n = intervals.Length;
        int[] res = new int[n];
        var starts = new (int start, int index)[n];

        for (int i = 0; i < n; i++)
        {
            starts[i] = (intervals[i][0], i);
        }
        System.Array.Sort(starts, (a, b) => a.start.CompareTo(b.start));

        for (int i = 0; i < n; i++)
        {
            int end = intervals[i][1];
            int min = 0, max = n - 1;
            int answerIndex = -1;

            while (min <= max)
            {
                int mid = (min + max) / 2;

                if (starts[mid].start >= end)
                {
                    answerIndex = starts[mid].index;
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }

            res[i] = answerIndex;
        }

        return res;
    }
}
