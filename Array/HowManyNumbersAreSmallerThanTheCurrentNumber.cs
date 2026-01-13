namespace Leetcode.Array;

public class HowManyNumbersAreSmallerThanTheCurrentNumber
{
    public int[] SmallerNumbersThanCurrent(int[] nums)
    {
        int n = nums.Length;
        int[] res = new int[n];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (nums[j] < nums[i])
                    res[i]++;
            }
        }

        return res;
    }


    /* // O(n) solution
    public int[] SmallerNumbersThanCurrent(int[] nums)
    {
        int n = nums.Length;
        int[] freq = new int[101];
        int[] smallerCount = new int[101];
        int[] res = new int[n];

        foreach (int num in nums)
            freq[num]++;

        for (int i = 1; i < freq.Length; i++)
            smallerCount[i] = freq[i - 1] + smallerCount[i - 1];

        for (int i = 0; i < n; i++)
            res[i] = smallerCount[nums[i]];

        return res;
    }
    */
}
