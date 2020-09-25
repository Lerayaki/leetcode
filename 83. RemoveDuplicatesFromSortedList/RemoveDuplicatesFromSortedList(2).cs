// Runtime: 88 ms, faster than 96.74% of C# online submissions for Remove Duplicates from Sorted List.
// Memory Usage: 26.6 MB, less than 5.29% of C# online submissions for Remove Duplicates from Sorted List.
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode DeleteDuplicates(ListNode head) {
        if (head == null || head.next == null)
            return head;
        
        ListNode current = head;
        while (current.next != null){
            if (current.val == current.next.val)
                current.next = current.next.next;
            else
                current = current.next;
        }
        return head;
    }
}