namespace LeetCode75.Solutions.LinkedList;

public class ListNode21
{
    public int val;
    public ListNode21 next;
    public ListNode21(int val = 0, ListNode21 next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution21
{
    public ListNode21 MergeTwoLists(ListNode21 list1, ListNode21 list2)
    {
        var list1CurrentNode = list1;
        var list2CurrentNode = list2;
        var mergedListHead = new ListNode21();
        var mergedListCurrentNode = mergedListHead;

        while (list1CurrentNode != null && list2CurrentNode != null)
        {
            if (list1CurrentNode.val <= list2CurrentNode.val)
            {
                mergedListCurrentNode.next = list1CurrentNode;
                list1CurrentNode = list1CurrentNode.next;
            }
            else
            {
                mergedListCurrentNode.next = list2CurrentNode;
                list2CurrentNode = list2CurrentNode.next;
            }

            mergedListCurrentNode = mergedListCurrentNode.next;
        }

        // If one of the lists is not fully traversed, append the rest of it to the merged list
        if (list1CurrentNode != null)
        {
            mergedListCurrentNode.next = list1CurrentNode;
        }
        else if (list2CurrentNode != null)
        {
            mergedListCurrentNode.next = list2CurrentNode;
        }

        return mergedListHead.next; // Return the next node to skip the dummy head
    }
}