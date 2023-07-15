public class RemoveNthFromEndSln {
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
    
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        if (n == 0)
        {
            return head;
        }

        ListNode left = head, right = head;
        while (n!=0)
        {
            right = right.next;
            n--;
        }

        if (right == null) return head.next;

        while (right.next != null)
        {
            left = left.next;
            right = right.next;
        }

        left = left.next.next;
        return head;
    }
}