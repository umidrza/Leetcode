namespace Leetcode.src.Solutions.Math_Problems;

// https://leetcode.com/problems/smallest-index-with-digit-sum-equal-to-index
public class SmallestIndexWithDigitSumEqualToIndex {
  
    public int SmallestIndex(int[] nums) {

        for (int i = 0; i < nums.Length; i++) {
            int num = nums[i];
            int digitSum = 0;

            while (num > 0) {
                digitSum += num % 10;
                num /= 10;
            }

            if (digitSum == i) return i;
        }

        return -1;
    }
}