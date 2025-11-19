namespace leetcode_csharp.invert_binary_tree;

public class Solution
{
    public TreeNode? InvertTree(TreeNode? root) => InvertNodeIfPresented(root);

    private static TreeNode? InvertNodeIfPresented(TreeNode? image)
    {
        if (image == null)
            return null;
        var leftNode = image.left;
        image.left = InvertNodeIfPresented(image.right);
        image.right = InvertNodeIfPresented(leftNode);
        return image;
    }

    private static TreeNode? CreateInvertedNodeIfPresented(TreeNode? image)
    {
        if (image == null)
            return null;
        var leftNode = CreateInvertedNodeIfPresented(image.right);
        var rightNode = CreateInvertedNodeIfPresented(image.left);
        return new TreeNode(image.val, leftNode, rightNode);
    }
}