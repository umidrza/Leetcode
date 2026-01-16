namespace Leetcode.Heap;

//https://leetcode.com/problems/last-stone-weight
public class LastStoneWeightSolution
{
    public int LastStoneWeight(int[] stones)
    {
        var pq = new MyPriorityQueue(stones);

        while (pq.Count > 1)
        {
            int first = pq.Dequeue();
            int second = pq.Dequeue();

            if (first != second)
                pq.Enqueue(first - second);
        }

        return pq.Count > 0 ? pq.Dequeue() : 0;
    }
}

class MyPriorityQueue 
{
    private readonly List<int> list;
    public int Count => list.Count;
    public MyPriorityQueue(IEnumerable<int> list)
    {
        this.list = [.. list];
        BuildHeap();
    }

    public int Dequeue()
    {
        int max = list[0];
        list[0] = list[^1];
        list.RemoveAt(list.Count - 1);

        HeapifyDown(list.Count, 0);
        return max;
    }

    public void Enqueue(int value)
    {
        list.Add(value);
        HeapifyUp(list.Count - 1);
    }

    private void BuildHeap()
    {
        int n = list.Count;
        for (int i = n / 2 - 1; i >= 0; i--)
        {
            HeapifyDown(n, i);
        }
    }

    private void HeapifyDown(int n, int root)
    {
        int largest = root;
        int left = 2 * root + 1;
        int right = 2 * root + 2;

        if (left < n && list[left] > list[largest])
            largest = left;
        if (right < n && list[right] > list[largest])
            largest = right;

        if (largest != root)
        {
            Swap(root, largest);
            HeapifyDown(n, largest);
        }
    }

    private void HeapifyUp(int index)
    {
        while (index > 0)
        {
            int parent = (index - 1) / 2;

            if (list[index] <= list[parent])
                break;

            Swap(index, parent);
            index = parent;
        }
    }

    private void Swap(int i, int j)
    {
        int temp = list[i];
        list[i] = list[j];
        list[j] = temp;
    }
}