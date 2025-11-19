namespace leetcode_csharp;

public sealed class TreeNode
{
    public int val;
    public TreeNode? left;
    public TreeNode? right;

    public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }

    private bool Equals(TreeNode other) =>
        val == other.val && Equals(left, other.left) && Equals(right, other.right);

    public override bool Equals(object? obj) =>
        ReferenceEquals(this, obj) || obj is TreeNode other && Equals(other);

    public override int GetHashCode() =>
        HashCode.Combine(val, left, right);
}