// Runtime: 84 ms, faster than 99.39% of C# online submissions for Remove Duplicates from Sorted List.
// Memory Usage: 26.7 MB, less than 5.29% of C# online submissions for Remove Duplicates from Sorted List.
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
        
        ListNode l = head;
        ListNode r = head.next;
        while (r != null){
            while (l.val == r.val){
                r = r.next;
                if (r == null){
                    l.next = null;
                    return head;
                }
            }
            l.next = r;
            l = r;
            r = r.next;
        }
        return head;
    }
}