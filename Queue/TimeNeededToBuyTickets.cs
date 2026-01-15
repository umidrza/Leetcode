namespace Leetcode.Queue;

//https://leetcode.com/problems/time-needed-to-buy-tickets
public class TimeNeededToBuyTickets
{
    public int TimeRequiredToBuy(int[] tickets, int k)
    {
        int res = 0;

        for (int i = 0; i < tickets.Length; i++)
        {
            res += Math.Min(tickets[i], tickets[k]);

            if (i > k && tickets[i] >= tickets[k])
                res--;
        }

        return res;
    }
}
