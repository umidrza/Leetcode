namespace Leetcode.src.Solutions.MonotonicStack;

//https://leetcode.com/problems/smallest-subsequence-of-distinct-characters
//https://leetcode.com/problems/remove-duplicate-letters/
public class SmallestSubsequenceOfDistinctCharacters
{
    public string SmallestSubsequence(string s)
    {
        int[] count = new int[26];
        bool[] used = new bool[26];
        Stack<char> stack = new Stack<char>();

        foreach (char c in s)
            count[c - 'a']++;

        foreach (char c in s)
        {
            int index = c - 'a';
            count[index]--;

            if (used[index])
                continue;

            while (stack.Count > 0 && c < stack.Peek() && count[stack.Peek() - 'a'] > 0)
            {
                used[stack.Pop() - 'a'] = false;
            }

            stack.Push(c);
            used[index] = true;
        }

        char[] result = stack.ToArray();
        System.Array.Reverse(result);

        return new string(result);
    }
}
