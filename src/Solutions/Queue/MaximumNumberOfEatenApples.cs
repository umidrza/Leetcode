namespace Leetcode.src.Solutions.Queue;

// https://leetcode.com/problems/maximum-number-of-eaten-apples
public class MaximumNumberOfEatenApples
{
    public int EatenApples(int[] apples, int[] days)
    {
        int n = apples.Length;
        int eaten = 0;
        var pq = new PriorityQueue<(int expireDay, int count), int>();

        int day = 0;
        while (day < n || pq.Count > 0)
        {
            // Add new apples grown today
            if (day < n && apples[day] > 0)
            {
                pq.Enqueue((day + days[day], apples[day]), day + days[day]);
            }

            // Remove rotten apples
            while (pq.Count > 0 && pq.Peek().expireDay <= day)
            {
                pq.Dequeue();
            }

            // Eat an apple if available
            if (pq.Count > 0)
            {
                var current = pq.Dequeue();
                current.count--;
                eaten++;
                if (current.count > 0)
                {
                    pq.Enqueue((current.expireDay, current.count), current.expireDay);
                }
            }

            day++;
        }

        return eaten;
    }
}
