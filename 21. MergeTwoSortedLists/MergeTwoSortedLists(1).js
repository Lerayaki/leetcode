// Runtime: 88 ms, faster than 69.05% of JavaScript online submissions for Merge Two Sorted Lists.
// Memory Usage: 38.5 MB, less than 77.74% of JavaScript online submissions for Merge Two Sorted Lists.
/**
 * @param {ListNode} l1
 * @param {ListNode} l2
 * @return {ListNode}
 */
var mergeTwoLists = function(l1, l2) {
    if (l1 == null && l2 == null)
            return null;
        if (l1 == null)
            return l2;
        if (l2 == null)
            return l1;
        
        var first, current;
        
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
};