namespace Leetcode.src.Solutions.Recursion;

// https://leetcode.com/problems/predict-the-winner
public class PredictTheWinnerSolution
{
    public bool PredictTheWinner(int[] nums)
    {
        return Play(0, nums.Length - 1, 0, 0, true, nums);
    }

    bool Play(int left, int right, int player1, int player2, bool turn, int[] nums)
    {
        if (left > right)
            return player1 >= player2;

        if (turn)
        {
            return Play(left + 1, right, player1 + nums[left], player2, false, nums) ||
                   Play(left, right - 1, player1 + nums[right], player2, false, nums);
        }
        else
        {
            return Play(left + 1, right, player1, player2 + nums[left], true, nums) &&
                   Play(left, right - 1, player1, player2 + nums[right], true, nums);
        }
    }
}
