using System.Xml;

public class IsPalindromeListSln {
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
    
    public bool IsPalindrome(ListNode head)
    {
        var slow = head;
        var fast = head;
        ListNode previous = null;

        while (fast!= null && fast.next != null)
        {
            fast = fast.next.next;
            var next = slow.next;
            slow.next = previous;
            previous = slow;
            slow = next;
        }

        if (fast != null)
        {
            slow = slow.next;
        }

        while (slow!=null)
        {
            if (slow.val != previous.val)
                return false;
            slow = slow.next;
            previous = previous.next;
        }

        return true;
    }
}
