namespace Leetcode.src.Solutions.Sorting;

// https://leetcode.com/problems/minimum-cost-of-buying-candies-with-discount
public class MinimumCostOfBuyingCandiesWithDiscount
{
    public int MinimumCost(int[] cost)
    {
        System.Array.Sort(cost);
        System.Array.Reverse(cost);
        int res = 0;

        for (int i = 0; i < cost.Length; i++)
        {
            if ((i + 1) % 3 == 0) continue;
            res += cost[i];
        }

        return res;
    }
}
