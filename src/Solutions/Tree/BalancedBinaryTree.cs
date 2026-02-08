using Leetcode.src.Definitions;

namespace Leetcode.src.Solutions.Tree;

// https://leetcode.com/problems/balanced-binary-tree
public class BalancedBinaryTree
{
    public bool IsBalanced(TreeNode root)
    {
        if (root == null) return true;

        if (Math.Abs(GetHeight(root.left) - GetHeight(root.right)) > 1)
            return false;

        return IsBalanced(root.left) && IsBalanced(root.right);
    }

    public int GetHeight(TreeNode root)
    {
        if (root == null) return 0;
        return Math.Max(GetHeight(root.right), GetHeight(root.left)) + 1;
    }
}
