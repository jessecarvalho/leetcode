public class Solution {
    public ListNode ReverseList(ListNode head) {
        if (head == null || head.next == null) {
            return head;
        }
        ListNode reversed = ReverseList(head.next);
        head.next.next = head;
        head.next = null;
        return reversed;
    }
}