namespace Leetcode.src.Solutions.Hash;

// https://leetcode.com/problems/find-the-prefix-common-array-of-two-arrays
public class FindThePrefixCommonArrayOfTwoArrays
{
    public int[] FindThePrefixCommonArray(int[] A, int[] B)
    {
        int n = A.Length;
        bool[] seen = new bool[n + 1];
        int[] res = new int[n];
        int curr = 0;

        for (int i = 0; i < n; i++)
        {
            if (seen[A[i]]) curr++;
            seen[A[i]] = true;

            if (seen[B[i]]) curr++;
            seen[B[i]] = true;

            res[i] = curr;
        }

        return res;
    }
}
