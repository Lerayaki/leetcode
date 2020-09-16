// Runtime: 0 ms, faster than 100.00% of Go online submissions for Merge Two Sorted Lists.
// Memory Usage: 2.5 MB, less than 99.77% of Go online submissions for Merge Two Sorted Lists.
/**
* Definition for singly-linked list.
* type ListNode struct {
*     Val int
*     Next *ListNode
* }
*/
func mergeTwoLists(l1 *ListNode, l2 *ListNode) *ListNode {
    if (l1 == nil && l2 == nil){ return nil }
    if (l1 == nil) { return l2 }
    if (l2 == nil){ return l1 }

    var first, current *ListNode

    if (l1.Val < l2.Val){
        first = l1
        current = l1
        l1 = l1.Next
    }else{
        first = l2
        current = l2
        l2 = l2.Next
    }

    for (l1 != nil || l2 != nil){
        if (l1 == nil){
            current.Next = l2
            current = current.Next
            l2 = l2.Next
            continue
        }
        if (l2 == nil){
            current.Next = l1
            current = current.Next
            l1 = l1.Next
            continue
        }

        if (l1.Val < l2.Val){
            current.Next = l1
            current = current.Next
            l1 = l1.Next
            continue
        }else{
            current.Next = l2
            current = current.Next
            l2 = l2.Next
        }   
    }
    
    return first
}