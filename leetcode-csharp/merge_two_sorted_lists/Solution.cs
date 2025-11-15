namespace leetcode_csharp.merge_two_sorted_lists;

public class Solution {
    public ListNode? MergeTwoLists(ListNode? list1, ListNode? list2) {
        if (list1 == null) return list2;
        if (list2 == null) return list1;
        return MergeNodes(null, list1, list2);
    }

    private static ListNode? MergeNodes(ListNode? previousNode, ListNode? node1, ListNode? node2) {
        ListNode? nextPreviousNode;
        ListNode? nextCandidate1;
        ListNode? nextCandidate2;
        if ((node2 == null) || ((node1 != null) && (node1.val < node2.val))) {
            if (previousNode != null)
                previousNode.next = node1;
            nextPreviousNode = node1;
            nextCandidate1 = node1.next;
            nextCandidate2 = node2;
        } else {
            if (previousNode != null)
                previousNode.next = node2;
            nextPreviousNode = node2;
            nextCandidate1 = node1;
            nextCandidate2 = node2.next;
        }
        if (nextCandidate1 != null || nextCandidate2 != null)
            MergeNodes(nextPreviousNode, nextCandidate1, nextCandidate2);
        return nextPreviousNode;
    }
}