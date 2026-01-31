namespace Leetcode.src.Solutions.BinarySearch;

// https://leetcode.com/problems/find-smallest-letter-greater-than-target
public class FindSmallestLetterGreaterThanTarget
{
    public char NextGreatestLetter(char[] letters, char target)
    {
        int min = 0, max = letters.Length - 1, res = 0;

        while (min <= max)
        {
            int mid = (min + max) / 2;

            if (letters[mid] > target)
            {
                res = mid;
                max = mid - 1;
            }
            else
            {
                min = mid + 1;
            }
        }

        return letters[res];
    }
}
