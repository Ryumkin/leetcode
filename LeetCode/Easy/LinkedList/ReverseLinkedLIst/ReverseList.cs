using System.Xml;

public class ReverseListSln {
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
    
    public ListNode ReverseList(ListNode head)
    {
        ListNode previous = null;

        while (head != null)
        {
            var next = head.next;
            head.next = previous;
            previous = head;
            head = next;
        }

        return previous;
    }
}
