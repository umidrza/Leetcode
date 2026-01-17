namespace Leetcode.src.Solutions.Array;

//https://leetcode.com/problems/valid-mountain-array
public class ValidMountainArraySolution
{
    public bool ValidMountainArray(int[] arr)
    {
        int n = arr.Length;
        if (n < 3) return false;

        int left = 0, right = n - 1;

        while (left < right)
        {
            if (arr[left] < arr[left + 1])
                left++;
            else if (arr[right - 1] > arr[right])
                right--;
            else
                return false;
        }

        return left != 0 && right != n - 1;
    }
}
