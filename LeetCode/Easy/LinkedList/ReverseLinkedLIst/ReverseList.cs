using System.Xml;

public class ReverseListSln {
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
    
    public ListNode ReverseList(ListNode head)
    {
        ListNode previous = null, next = null;

        while (head != null)
        {
            next = head.next;
            head.next = previous;
            previous = head;
            head = next;
        }

        return previous;
    }
}