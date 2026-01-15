namespace Leetcode.Queue;

//https://leetcode.com/problems/implement-queue-using-stacks
public class MyQueue
{
    private Stack<int> input;
    private Stack<int> output;

    public MyQueue()
    {
        input = new Stack<int>();
        output = new Stack<int>();
    }

    public void Push(int x)
    {
        input.Push(x);
    }

    public int Pop()
    {
        ShiftStacks();
        return output.Pop();
    }

    public int Peek()
    {
        ShiftStacks();
        return output.Peek();
    }

    public bool Empty()
    {
        return input.Count == 0 && output.Count == 0;
    }

    private void ShiftStacks()
    {
        if (output.Count > 0) return;

        while (input.Count > 0)
        {
            output.Push(input.Pop());
        }
    }
}
