namespace leetcode_csharp.merge_two_sorted_lists;

public class Solution
{
    public ListNode? MergeTwoLists(ListNode? list1, ListNode? list2) =>
        MergeTwoListsToNewList(list1, list2);

    private static ListNode? MergeTwoListsByChangingNodes(ListNode? list1, ListNode? list2)
    {
        var rootNode = GetCandidateToAppend(list1, list2);
        if (rootNode is null) return null;

        var candidateToPostpone = ReferenceEquals(rootNode, list1) ? list2 : list1;
        var currentNode = rootNode;
        while (true)
        {
            var candidateToAppend = GetCandidateToAppend(currentNode.next, candidateToPostpone);
            if (candidateToAppend is null)
                break;
            candidateToPostpone = ReferenceEquals(candidateToAppend, currentNode.next)
                ? candidateToPostpone
                : currentNode.next;
            currentNode.next = candidateToAppend;
            currentNode = currentNode.next;
        }

        return rootNode;
    }

    private static ListNode? MergeTwoListsToNewList(ListNode? list1, ListNode? list2)
    {
        var rootNode = GetCandidateToAppend(list1, list2);
        if (rootNode == null) return null;
        var newList = new ListNode(rootNode.val);

        var node1 = rootNode.next;
        var node2 = ReferenceEquals(rootNode, list1) ? list2 : list1;
        var currentNode = newList;
        while (true)
        {
            var candidate = GetCandidateToAppend(node1, node2);
            if (candidate == null)
                break;
            if (ReferenceEquals(candidate, node1))
                node1 = node1.next;
            else
                node2 = node2!.next;
            currentNode.next = new ListNode(candidate.val);
            currentNode = currentNode.next;
        }

        return newList;
    }

    private static ListNode? GetCandidateToAppend(ListNode? node1, ListNode? node2)
    {
        if (node1 is null) return node2;
        if (node2 is null) return node1;
        return node1.val < node2.val ? node1 : node2;
    }
}