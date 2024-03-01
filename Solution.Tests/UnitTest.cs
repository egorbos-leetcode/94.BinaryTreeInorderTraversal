using BinaryTree;

namespace Solution.Tests;

public class UnitTest
{
    [Fact]
    public void Test()
    {
#pragma warning disable CS8604 // Possible null reference argument.
        Assert.Equal([1, 3, 2], Solution.InorderTraversal(TreeNode.BuildTree<int>([1, null, 2, 3])));
        Assert.Equal([], Solution.InorderTraversal(TreeNode.BuildTree<int>([])));
        Assert.Equal([1], Solution.InorderTraversal(TreeNode.BuildTree<int>([1])));
#pragma warning restore CS8604 // Possible null reference argument.
    }
}