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
    public ListNode ReverseList(ListNode head) 
    {
        ListNode prev = null;
        ListNode temp = head;
        ListNode fut = head;

        while(temp!=null)
        {
            fut = fut.next;
            temp.next = prev;
            prev = temp;
            temp = fut;
        }
        return prev;
    }
}
