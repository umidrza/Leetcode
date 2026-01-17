namespace Leetcode.src.Definitions;

public class Node
{
    public int val;
    public Node next;
    public Node random;

    public Node(int _val)
    {
        val = _val;
        next = null;
        random = null;
    }

    public override string ToString()
    {
        string nextNode = next?.ToString() ?? "null";
        string randomVal = random?.val.ToString() ?? "null";

        return $"value: {val.ToString()}, random value: {randomVal} -> {nextNode}";
    }
}