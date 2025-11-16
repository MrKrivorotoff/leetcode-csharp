namespace leetcode_csharp;

public sealed class ListNode
{
    public int val;
    public ListNode? next;

    public ListNode(int val = 0, ListNode? next = null)
    {
        this.val = val;
        this.next = next;
    }

    public static ListNode? OfValues() => null;
    
    public static ListNode OfValues(params ReadOnlySpan<int> values) {
        if (values.IsEmpty)
            throw new ArgumentException(null, nameof(values));
        var current = new ListNode(values[^1]);
        for (var i = values.Length - 2; i >= 0; i--)
            current = new ListNode(values[i], current);
        return current;
    }

    private bool Equals(ListNode other) =>
        val == other.val && Equals(next, other.next);

    public override bool Equals(object? obj) =>
        ReferenceEquals(this, obj) || obj is ListNode other && Equals(other);

    public override int GetHashCode() =>
        HashCode.Combine(val, next);

    public override string ToString() =>
        ToString(this);

    public static string ToString(ListNode? head) =>
        $"[{string.Join(", ", GetValues(head))}]";

    private static IEnumerable<int> GetValues(ListNode? head)
    {
        for (var node = head; node != null; node = node.next)
            yield return node.val;
    }
}