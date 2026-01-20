namespace Leetcode.src.Solutions.BinarySearch;

// https://leetcode.com/problems/minimum-number-of-days-to-make-m-bouquets
public class MinimumNumberOfDaysToMakeMBouquets
{
    public int MinDays(int[] bloomDay, int m, int k)
    {
        int n = bloomDay.Length;
        if ((long)m * k > n) return -1;

        int min = bloomDay.Min();
        int max = bloomDay.Max();
        int answer = -1;

        while (min <= max)
        {
            int mid = min + (max - min) / 2;

            if (CanMakeBouquets(bloomDay, m, k, mid))
            {
                answer = mid;
                max = mid - 1;
            }
            else
            {
                min = mid + 1;
            }
        }

        return answer;
    }

    private bool CanMakeBouquets(int[] bloomDay, int m, int k, int day)
    {
        int bouquets = 0;
        int consecutive = 0;

        foreach (int bloom in bloomDay)
        {
            if (bloom <= day)
            {
                consecutive++;
                if (consecutive == k)
                {
                    bouquets++;
                    consecutive = 0;
                    if (bouquets == m) return true;
                }
            }
            else
            {
                consecutive = 0;
            }
        }

        return bouquets >= m;
    }
}
