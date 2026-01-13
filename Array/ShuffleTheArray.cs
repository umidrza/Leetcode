namespace Leetcode.Array;

public class ShuffleTheArray
{
    public int[] Shuffle(int[] nums, int n)
    {
        int[] res = new int[n * 2];
        int index = 0;

        for (int i = 0; i < n; i++)
        {
            res[index++] = nums[i];
            res[index++] = nums[i + n];
        }

        return res;
    }
}
