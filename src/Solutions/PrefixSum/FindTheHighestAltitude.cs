namespace Leetcode.src.Solutions.PrefixSum;

// https://leetcode.com/problems/find-the-highest-altitude
public class FindTheHighestAltitude
{
    public int LargestAltitude(int[] gain)
    {
        int maxAltitude = 0, currAltitude = 0;

        foreach (int g in gain)
        {
            currAltitude += g;
            maxAltitude = Math.Max(currAltitude, maxAltitude);
        }

        return maxAltitude;
    }
}
