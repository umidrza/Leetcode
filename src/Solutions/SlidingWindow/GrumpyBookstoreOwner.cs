namespace Leetcode.src.Solutions.SlidingWindow;

// https://leetcode.com/problems/grumpy-bookstore-owner
public class GrumpyBookstoreOwner
{
    public int MaxSatisfied(int[] customers, int[] grumpy, int minutes)
    {
        int baseSatisfied = 0;
        int extraSatisfied = 0;
        int maxExtraSatisfied = 0;

        for (int i = 0; i < minutes; i++)
        {
            if (grumpy[i] == 0)
                baseSatisfied += customers[i];
            else
                extraSatisfied += customers[i];
        }
        maxExtraSatisfied = Math.Max(extraSatisfied, maxExtraSatisfied);

        for (int i = minutes; i < customers.Length; i++)
        {
            if (grumpy[i] == 0)
                baseSatisfied += customers[i];
            else
                extraSatisfied += customers[i];

            if (grumpy[i - minutes] == 1)
                extraSatisfied -= customers[i - minutes];

            maxExtraSatisfied = Math.Max(extraSatisfied, maxExtraSatisfied);
        }

        return baseSatisfied + maxExtraSatisfied;
    }
}
