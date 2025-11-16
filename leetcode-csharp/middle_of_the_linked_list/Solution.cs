namespace leetcode_csharp.middle_of_the_linked_list;

public class Solution
{
    public ListNode MiddleNode(ListNode head)
    {
        var middleNode = head;
        for (var node = head; node?.next != null; node = node.next.next)
            middleNode = middleNode!.next;
        return middleNode!;
    }
}