using TreeNode = BinaryTree.TreeNode<int>;

namespace Solution;

public static class Solution
{
    public static IList<int> InorderTraversal(TreeNode root)
    {
        var list = new List<int>();
        if (root is null) return list;

        var current = root;
        var stack = new Stack<TreeNode>();

        while (current is not null || stack.Count > 0)
        {
            while (current is not null)
            {
                stack.Push(current);
                current = current.left;
            }
            var top = stack.Pop();
            list.Add(top.val);
            current = top.right;
        }

        return list;
    }
}
