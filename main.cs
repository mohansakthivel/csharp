using System;

class Program {
    
  /* Linked list Node*/
  public class LinkedList
  {
      public int data;
      public LinkedList next;
      public LinkedList(int d) 
      {
        data = d; 
        next = null; 
      }
  }
  
  public static bool hasCycle(LinkedList head) {
    LinkedList slow = head;
    LinkedList fast = head;
    while (fast != null && fast.next != null) {
      fast = fast.next.next;
      slow = slow.next;
      if (slow == fast)
        return true; // found the cycle
    }
    return false;
  }

  public static void Main(String[] args) {
    LinkedList head = new LinkedList(1);  
    head.next = new LinkedList(2);
    head.next.next = new LinkedList(3);
    head.next.next.next = new LinkedList(4);
    head.next.next.next.next = new LinkedList(5);
    head.next.next.next.next.next = new LinkedList(6);
    
    Console.WriteLine("LinkedList has cycle tytytyty: {0}" , hasCycle(head));

    head.next.next.next.next.next.next = head.next.next;
    
    Console.WriteLine("LinkedList has cycle: {0}" , hasCycle(head));

    head.next.next.next.next.next.next = head.next.next.next;
    
    Console.WriteLine("LinkedList has cycle: {0}" , hasCycle(head));
  }
}
