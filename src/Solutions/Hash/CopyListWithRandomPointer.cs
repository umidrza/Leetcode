using Leetcode.src.Definitions;

namespace Leetcode.src.Solutions.Hash;

// https://leetcode.com/problems/copy-list-with-random-pointer
public class CopyListWithRandomPointer
{
    public Node CopyRandomList(Node head)
    {
        if (head == null) return null;
        Dictionary<Node, Node> map = new Dictionary<Node, Node>();
        Node dummy = head;

        while (head != null)
        {
            map[head] = new Node(head.val);
            head = head.next;
        }
        head = dummy;

        while (head != null)
        {
            Node copyNode = map[head];
            copyNode.next = head.next == null ? null : map[head.next];
            copyNode.random = head.random == null ? null : map[head.random];

            head = head.next;
        }

        return map[dummy];
    }
}
