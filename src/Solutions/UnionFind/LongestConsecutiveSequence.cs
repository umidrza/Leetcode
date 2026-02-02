namespace Leetcode.src.Solutions.UnionFind;

// https://leetcode.com/problems/longest-consecutive-sequence
public class LongestConsecutiveSequence
{
    public int LongestConsecutive(int[] nums)
    {
        Dictionary<int, bool> map = new Dictionary<int, bool>();
        foreach (int num in nums)
        {
            map[num] = false;
        }

        int max = 0;
        foreach (int num in map.Keys)
        {
            if (map[num] == true) continue;

            int count = 1;
            int prev = num - 1;
            int next = num + 1;

            while (map.ContainsKey(prev))
            {
                map[prev] = true;
                count++;
                prev--;
            }
            while (map.ContainsKey(next))
            {
                map[next] = true;
                count++;
                next++;
            }

            max = Math.Max(max, count);
        }

        return max;
    }
}
