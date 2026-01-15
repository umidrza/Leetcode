namespace Leetcode.Heap;

//https://leetcode.com/problems/find-k-pairs-with-smallest-sums
public class FindKPairsWithSmallestSums
{
    public IList<IList<int>> KSmallestPairs(int[] nums1, int[] nums2, int k)
    {
        var q = new PriorityQueue<(int, int), int>(k + 1);
        var result = new List<IList<int>>();
        var visited = new HashSet<(int, int)>();
        Add(0, 0);

        while (q.Count > 0 && result.Count != k)
        {
            var (i, j) = q.Dequeue();
            result.Add([nums1[i], nums2[j]]);
            Add(i + 1, j);
            Add(i, j + 1);
        }

        return result;

        void Add(int i, int j)
        {
            if (i >= nums1.Length || j >= nums2.Length) return;
            if (visited.Contains((i, j))) return;

            q.Enqueue((i, j), nums1[i] + nums2[j]);
            visited.Add((i, j));
        }
    }
}
