namespace Leetcode.Stack;

public class EvaluateReversePolishNotation
{
    public int EvalRPN(string[] tokens)
    {
        var ops = new Dictionary<string, Func<int, int, int>>
        {
            ["+"] = (x, y) => x + y,
            ["-"] = (x, y) => x - y,
            ["*"] = (x, y) => x * y,
            ["/"] = (x, y) => x / y
        };
        Stack<int> stack = new Stack<int>();

        foreach (string token in tokens)
        {
            if (int.TryParse(token, out int num))
            {
                stack.Push(num);
            }
            else
            {
                var b = stack.Pop();
                var a = stack.Pop();

                int res = ops[token](a, b);
                stack.Push(res);
            }
        }

        return stack.Pop();
    }
}
