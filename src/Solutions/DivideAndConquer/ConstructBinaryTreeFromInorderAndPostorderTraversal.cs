using Leetcode.src.Definitions;

namespace Leetcode.src.Solutions.DivideAndConquer;

// https://leetcode.com/problems/construct-binary-tree-from-inorder-and-postorder-traversal
public class ConstructBinaryTreeFromInorderAndPostorderTraversal
{
    public TreeNode BuildTree(int[] inorder, int[] postorder)
    {
        int n = inorder.Length;
        var map = new Dictionary<int, int>();
        int postRootIndex = n - 1;

        for (int i = 0; i < n; i++)
            map[inorder[i]] = i;

        return BuildTree(inorder, postorder, 0, n - 1, ref postRootIndex, map);
    }

    private TreeNode BuildTree(int[] inorder, int[] postorder, int left, int right, ref int postRootIndex, Dictionary<int, int> map)
    {
        if (left > right) return null;

        TreeNode root = new TreeNode(postorder[postRootIndex--]);
        int inRootIndex = map[root.val];

        root.right = BuildTree(inorder, postorder, inRootIndex + 1, right, ref postRootIndex, map);
        root.left = BuildTree(inorder, postorder, left, inRootIndex - 1, ref postRootIndex, map);
        return root;
    }
}
