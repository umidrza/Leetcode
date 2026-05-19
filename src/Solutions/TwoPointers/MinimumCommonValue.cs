namespace Leetcode.src.Solutions.TwoPointers;

// https://leetcode.com/problems/minimum-common-value
public class MinimumCommonValue
{
    public int GetCommon(int[] nums1, int[] nums2)
    {
        int n = nums1.Length, m = nums2.Length;

        int i = 0, j = 0;
        while (i < n && j < m)
        {
            if (nums1[i] < nums2[j])
            {
                i++;
            }
            else if (nums1[i] > nums2[j])
            {
                j++;
            }
            else
            {
                return nums1[i];
            }
        }

        return -1;
    }
}
