namespace Leetcode.MonotonicStack;

public class FinalPricesWithASpecialDiscountInAShop
{
    public int[] FinalPrices(int[] prices)
    {
        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < prices.Length; i++)
        {
            while (stack.Count > 0 && prices[i] <= prices[stack.Peek()])
            {
                prices[stack.Pop()] -= prices[i];
            }

            stack.Push(i);
        }

        return prices;
    }
}
