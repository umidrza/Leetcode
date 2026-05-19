namespace Leetcode.src.Solutions.DFS;

// https://leetcode.com/problems/jump-game-iii
public class JumpGameIII
{
    public bool CanReach(int[] arr, int start)
    {
        int n = arr.Length;
        bool[] seen = new bool[n];

        bool DFS(int i)
        {
            if (i >= n || i < 0 || seen[i]) return false;
            if (arr[i] == 0) return true;
            seen[i] = true;

            return DFS(i + arr[i]) || DFS(i - arr[i]);
        }

        return DFS(start);
    }
}
