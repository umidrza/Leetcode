namespace Leetcode.src.Solutions.Greedy;

// https://leetcode.com/problems/cinema-seat-allocation
public class CinemaSeatAllocation
{
  public int MaxNumberOfFamilies(int n, int[][] reservedSeats)
  {
    var reserved = new HashSet<(int row, int group)>();

    foreach (int[] seats in reservedSeats)
    {
      int row = seats[0], seat = seats[1];

      if (seat == 2 || seat == 3)
      {
        reserved.Add((row, 1));
      }
      else if (seat == 4 || seat == 5)
      {
        reserved.Add((row, 1));
        reserved.Add((row, 2));
      }
      else if (seat == 6 || seat == 7)
      {
        reserved.Add((row, 2));
        reserved.Add((row, 3));
      }
      else if (seat == 8 || seat == 9)
      {
        reserved.Add((row, 3));
      }
    }

    var rows = reservedSeats.Select(x => x[0]).Distinct();
    int res = (n - rows.Count()) * 2;

    foreach (int row in rows)
    {
      bool left = !reserved.Contains((row, 1));
      bool middle = !reserved.Contains((row, 2));
      bool right = !reserved.Contains((row, 3));

      if (left && right)
        res += 2;
      else if (left || middle || right)
        res += 1;
    }

    return res;
  }
}
