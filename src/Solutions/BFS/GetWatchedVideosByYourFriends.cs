namespace Leetcode.src.Solutions.BFS;

// https://leetcode.com/problems/get-watched-videos-by-your-friends
public class GetWatchedVideosByYourFriends
{
    public IList<string> WatchedVideosByFriends(IList<IList<string>> watchedVideos, int[][] friends, int id, int level)
    {
        bool[] seen = new bool[friends.Length];
        Dictionary<string, int> freq = new();
        Queue<int> q = new();
        q.Enqueue(id);
        seen[id] = true;

        while (q.Count > 0)
        {
            int count = q.Count;
            level--;

            for (int i = 0; i < count; i++)
            {
                int curr = q.Dequeue();

                foreach (int next in friends[curr])
                {
                    if (seen[next]) continue;
                    seen[next] = true;

                    if (level != 0)
                    {
                        q.Enqueue(next);
                        continue;
                    }

                    foreach (string s in watchedVideos[next])
                    {
                        if (!freq.ContainsKey(s))
                            freq.Add(s, 0);
                        freq[s]++;
                    }
                }
            }
        }

        return freq.OrderBy(x => x.Value).ThenBy(x => x.Key).Select(x => x.Key).ToList();
    }
}
