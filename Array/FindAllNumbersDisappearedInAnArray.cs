namespace Leetcode.Array;

//https://leetcode.com/problems/find-all-numbers-disappeared-in-an-array
public class FindAllNumbersDisappearedInAnArray
{
    public IList<int> FindDisappearedNumbers(int[] nums)
    {
        int n = nums.Length;
        IList<int> res = new List<int>();
        bool[] seen = new bool[n + 1];

        foreach (int num in nums)
        {
            seen[num] = true;
        }

        for (int i = 1; i < n + 1; i++)
        {
            if (!seen[i])
            {
                res.Add(i);
            }
        }

        return res;
    }
}
