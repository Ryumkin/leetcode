using System.Xml;

public class LinkedListCycle {
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
    //https://www.geeksforgeeks.org/floyds-cycle-finding-algorithm/
    public bool HasCycle(ListNode head)
    {
        var slow = head;
        var fast = head;

        while (fast!= null && fast.next != null)
        {
            fast = fast.next.next;
            slow = slow.next;
            if (fast == slow)
            {
                return true;
            }
        }
        return false;
    }
}
