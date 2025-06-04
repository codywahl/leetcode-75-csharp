namespace LeetCode75.Solutions.LinkedList;


public class ListNode
{
    public int val;
    public ListNode? next;
    public ListNode(int val = 0, ListNode? next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution206
{
    public ListNode? ReverseList(ListNode head)
    {
        if (head == null)
        {
            return null;
        }

        ListNode? prev = null;
        ListNode? current = head;

        while (current != null)
        {
            ListNode? nextTemp = current.next; // Store the next node
            current.next = prev;              // Reverse the link
            prev = current;                   // Move prev to current
            current = nextTemp;               // Move to the next node
        }

        return prev; // New head of the reversed list
    }
}