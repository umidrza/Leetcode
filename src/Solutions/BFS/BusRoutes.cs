namespace Leetcode.src.Solutions.BFS;

// https://leetcode.com/problems/bus-routes
public class BusRoutes
{
    public int NumBusesToDestination(int[][] routes, int source, int target)
    {
        if (source == target) return 0;

        var stops = new Dictionary<int, List<int>>();

        for (int bus = 0; bus < routes.Length; bus++)
        {
            foreach (int stop in routes[bus])
            {
                if (!stops.ContainsKey(stop))
                    stops[stop] = new List<int>();

                stops[stop].Add(bus);
            }
        }

        if (!stops.ContainsKey(source) || !stops.ContainsKey(target))
            return -1;

        var visitedBuses = new HashSet<int>();
        var visitedStops = new HashSet<int>();
        var queue = new Queue<int>();

        foreach (int bus in stops[source])
        {
            queue.Enqueue(bus);
            visitedBuses.Add(bus);
        }

        int busesTaken = 1;

        while (queue.Count > 0)
        {
            int size = queue.Count;

            for (int i = 0; i < size; i++)
            {
                int bus = queue.Dequeue();

                foreach (int stop in routes[bus])
                {
                    if (stop == target)
                        return busesTaken;

                    if (!visitedStops.Add(stop))
                        continue;

                    foreach (int nextBus in stops[stop])
                    {
                        if (visitedBuses.Add(nextBus))
                            queue.Enqueue(nextBus);
                    }
                }
            }

            busesTaken++;
        }

        return -1;
    }
}
