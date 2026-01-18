namespace Leetcode.src.Solutions.Sorting;

// https://leetcode.com/problems/minimum-absolute-difference
public class MinimumAbsoluteDifference
{
    public IList<IList<int>> MinimumAbsDifference(int[] arr)
    {
        IList<IList<int>> res = [];
        int minDiff = int.MaxValue;
        System.Array.Sort(arr);

        for (int i = 1; i < arr.Length; i++)
        {
            int currDiff = arr[i] - arr[i - 1];

            if (currDiff < minDiff)
            {
                res.Clear();
                minDiff = currDiff;
            }

            if (currDiff == minDiff)
                res.Add([arr[i - 1], arr[i]]);
        }

        return res;
    }
}
