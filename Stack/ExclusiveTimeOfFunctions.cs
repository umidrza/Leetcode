namespace Leetcode.Stack;

//https://leetcode.com/problems/exclusive-time-of-functions
public class ExclusiveTimeOfFunctions
{
    public int[] ExclusiveTime(int n, IList<string> logs)
    {
        int[] res = new int[n];
        var paused = new Stack<int>();
        int currId = -1, currStartTime = -1;

        foreach (string log in logs)
        {
            var logDetails = log.Split(':');
            int id = int.Parse(logDetails[0]);
            bool isStarted = logDetails[1] == "start";
            int timestamp = int.Parse(logDetails[2]);

            if (isStarted)
            {
                // pause current
                if (currId != -1)
                {
                    res[currId] += timestamp - currStartTime;
                    paused.Push(currId);
                }

                // start new
                currId = id;
                currStartTime = timestamp;
            }
            else
            {
                // end current
                res[currId] += timestamp - currStartTime + 1;
                currId = -1;

                // resume last with new startTime
                if (paused.Count > 0)
                {
                    currId = paused.Pop();
                    currStartTime = timestamp + 1;
                }
            }
        }

        return res;
    }
}
