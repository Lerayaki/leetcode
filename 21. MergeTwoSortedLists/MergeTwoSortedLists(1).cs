// Runtime: 92 ms, faster than 86.07% of C# online submissions for Merge Two Sorted Lists.
// Memory Usage: 25.5 MB, less than 78.33% of C# online submissions for Merge Two Sorted Lists.
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
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        
        if (l1 == null && l2 == null)
            return null;
        if (l1 == null)
            return l2;
        if (l2 == null)
            return l1;
        
        ListNode first, current;
        
        if (l1.val < l2.val){
            first = current = l1;
            l1 = l1.next;
        }
        else{
            first = current = l2;
            l2 = l2.next;
        }   
        
        while (l1 != null || l2 != null){
            if (l1 == null){
                current.next = l2;
                current = current.next;
                l2 = l2.next;
                continue;
            }
            if (l2 == null){
                current.next = l1;
                current = current.next;
                l1 = l1.next;
                continue;
            }
            
            if (l1.val < l2.val){
                current.next = l1;
                current = current.next;
                l1 = l1.next;
                continue;
            }
            else{
                current.next = l2;
                current = current.next;
                l2 = l2.next;
            }   
        }
        
        return first;
    }
}