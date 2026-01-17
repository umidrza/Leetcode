namespace Leetcode.src.Solutions.Heap;

// https://leetcode.com/problems/construct-target-array-with-multiple-sums
public class ConstructTargetArrayWithMultipleSums
{
    public bool IsPossible(int[] target)
    {
        var pq = new PriorityQueue<int, int>();
        long sum = 0;

        foreach (int num in target)
        {
            pq.Enqueue(num, -num);
            sum += num;
        }

        while (true)
        {
            int largest = pq.Dequeue();
            long rest = sum - largest;

            if (largest == 1 || rest == 1) return true;
            if (rest == 0 || largest <= rest) return false;

            int newElement = (int)(largest % rest);
            if (newElement == 0) return false;

            pq.Enqueue(newElement, -newElement);
            sum = rest + newElement;
        }
    }
}
