namespace leetcode_csharp.merge_two_sorted_lists;

public class Solution
{
    public ListNode? MergeTwoLists(ListNode? list1, ListNode? list2)
    {
        var rootNode = GetCandidateToAppend(list1, list2);
        if (rootNode == null) return null;

        var currentNode = rootNode;
        var candidateToPostpone = ReferenceEquals(rootNode, list1) ? list2 : list1;
        while (true)
        {
            var candidateToAppend = GetCandidateToAppend(currentNode.next, candidateToPostpone);
            if (candidateToAppend == null) break;
            candidateToPostpone = ReferenceEquals(candidateToAppend, currentNode.next)
                ? candidateToPostpone
                : currentNode.next;
            currentNode.next = candidateToAppend;
            currentNode = currentNode.next;
        }

        return rootNode;
    }

    private static ListNode? GetCandidateToAppend(ListNode? node1, ListNode? node2)
    {
        if (node1 == null) return node2;
        if (node2 == null) return node1;
        return node1.val < node2.val ? node1 : node2;
    }
}