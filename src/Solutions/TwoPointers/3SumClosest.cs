namespace Leetcode.src.Solutions.TwoPointers;

// https://leetcode.com/problems/3sum-closest
public class _3SumClosest
{
    public int ThreeSumClosest(int[] nums, int target)
    {
        int n = nums.Length;
        int closestNumber = 0, closestDistance = int.MaxValue;
        System.Array.Sort(nums);

        for (int i = 0; i < n - 2; i++)
        {
            int left = i + 1, right = n - 1;

            while (left < right)
            {
                int sum = nums[i] + nums[left] + nums[right];
                int currentDistance = Math.Abs(target - sum);

                if (target == sum) return sum;
                else if (sum < target) left++;
                else right--;

                if (closestDistance > currentDistance)
                {
                    closestDistance = currentDistance;
                    closestNumber = sum;
                }
            }
        }

        return closestNumber;
    }
}
