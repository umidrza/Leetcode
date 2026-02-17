namespace Leetcode.src.Solutions.BitManipulation;

// https://leetcode.com/problems/binary-watch
public class BinaryWatch
{
    public IList<string> ReadBinaryWatch(int turnedOn)
    {
        IList<string> res = new List<string>();

        for (int minute = 0; minute < 60; minute++)
        {
            for (int hour = 0; hour < 12; hour++)
            {
                if (CountBits(minute) + CountBits(hour) == turnedOn)
                    res.Add($"{hour}:{minute:D2}");
            }
        }

        int CountBits(int num)
        {
            int count = 0;
            while (num != 0)
            {
                num &= num - 1;
                count++;
            }
            return count;
        }

        return res;
    }
}
