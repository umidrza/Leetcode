namespace Leetcode.src.Solutions.Sorting;

// https://leetcode.com/problems/reduction-operations-to-make-the-array-elements-equal
public class ReductionOperationsToMakeTheArrayElementsEqual
{
    public int ReductionOperations(int[] nums)
    {
        System.Array.Sort(nums);
        int res = 0;
        int distinctCount = 0;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] == nums[0]) continue;

            if (nums[i - 1] != nums[i])
                distinctCount++;

            res += distinctCount;
        }

        return res;
    }
}
