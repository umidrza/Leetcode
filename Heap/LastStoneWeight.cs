namespace Leetcode.Heap;

//https://leetcode.com/problems/last-stone-weight
public class LastStoneWeightSolution
{
    public int LastStoneWeight(int[] stones)
    {
        int n = stones.Length;
        var heap = new List<int>(stones);
        BuildHeap(heap);

        while (heap.Count > 1)
        {
            int first = ExtractMax(heap);
            int second = ExtractMax(heap);

            if (first != second)
                Insert(heap, first - second);
        }

        return heap.Count == 1 ? heap[0] : 0;
    }

    private void BuildHeap(List<int> heap)
    {
        int n = heap.Count;
        for (int i = n / 2 - 1; i >= 0; i--)
        {
            HeapifyDown(heap, n, i);
        }
    }

    private void HeapifyDown(List<int> list, int n, int root)
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
            Swap(list, root, largest);
            HeapifyDown(list, n, largest);
        }
    }

    private void HeapifyUp(List<int> list, int index)
    {
        while (index > 0)
        {
            int parent = (index - 1) / 2;

            if (list[index] <= list[parent])
                break;

            Swap(list, index, parent);
            index = parent;
        }
    }

    private int ExtractMax(List<int> list)
    {
        if (list.Count == 0) return 0;

        int max = list[0];
        list[0] = list[^1];
        list.RemoveAt(list.Count - 1);

        HeapifyDown(list, list.Count, 0);
        return max;
    }

    public void Insert(List<int> list, int value)
    {
        list.Add(value);
        HeapifyUp(list, list.Count - 1);
    }


    private void Swap(List<int> list, int i, int j)
    {
        int temp = list[i];
        list[i] = list[j];
        list[j] = temp;
    }
}
