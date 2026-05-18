namespace Leetcode.src.Solutions.BFS;

public class JumpGameIV
{
    public int MinJumps(int[] arr)
    {
        int n = arr.Length;
        var map = new Dictionary<int, List<int>>();

        for (int i = 0; i < n; i++)
        {
            int value = arr[i];

            if (!map.ContainsKey(value))
            {
                map[value] = new List<int>();
            }

            map[value].Add(i);
        }

        bool[] seen = new bool[n];
        var q = new Queue<int>();
        q.Enqueue(0);
        seen[0] = true;
        int steps = 0;

        while (q.Count > 0)
        {
            int count = q.Count;

            for (int k = 0; k < count; k++)
            {
                int i = q.Dequeue();
                if (i == n - 1) return steps;
                seen[i] = true;

                if (i + 1 < n && !seen[i + 1])
                {
                    q.Enqueue(i + 1);
                }

                if (i - 1 >= 0 && !seen[i - 1])
                {
                    q.Enqueue(i - 1);
                }

                foreach (int j in map[arr[i]])
                {
                    if (seen[j]) continue;
                    q.Enqueue(j);
                }

                map[arr[i]].Clear();
            }

            steps++;
        }

        return -1;
    }
}
