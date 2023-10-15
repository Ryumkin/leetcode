var lst1 = new MergeTwoListsSln.ListNode(1);
lst1.next = new MergeTwoListsSln.ListNode(2);
lst1.next.next = new MergeTwoListsSln.ListNode(4);

var lst2 = new MergeTwoListsSln.ListNode(1);
lst2.next = new MergeTwoListsSln.ListNode(3);
lst2.next.next = new MergeTwoListsSln.ListNode(4);
Console.Write(new MergeTwoListsSln().MergeTwoLists(lst1, lst2));
