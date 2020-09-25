// Runtime: 96 ms, faster than 69.35% of C# online submissions for Remove Duplicates from Sorted List II.
// Memory Usage: 26.2 MB, less than 5.03% of C# online submissions for Remove Duplicates from Sorted List II.
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
        
        if (head.val != head.next.val){
            head.next = DeleteDuplicates(head.next);
            return head;
        }
        
        if (head.next.next == null)
            return null;
        
        while (head.next != null && head.val == head.next.val){
            head = head.next;
        }
        return DeleteDuplicates(head.next);
    }
}