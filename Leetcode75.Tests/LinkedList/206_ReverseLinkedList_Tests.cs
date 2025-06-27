using Xunit;
using LeetCode75.Solutions.LinkedList;

namespace LeetCode75.Tests.LinkedList;

public class ReverseLinkedListTests
{
    private readonly Solution206 _solution = new Solution206();

    // Example 1: Input: head = [1,2,3,4,5] Output: [5,4,3,2,1]
    [Fact]
    public void Test1()
    {
        var head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
        var expected = new ListNode(5, new ListNode(4, new ListNode(3, new ListNode(2, new ListNode(1)))));

        var result = _solution.ReverseList(head);

        Assert.Equal(expected.val, result.val);
        Assert.Equal(expected.next.val, result.next.val);
        Assert.Equal(expected.next.next.val, result.next.next.val);
        Assert.Equal(expected.next.next.next.val, result.next.next.next.val);
        Assert.Equal(expected.next.next.next.next.val, result.next.next.next.next.val);
    }

    // Example 2: Input: head = [1,2] Output: [2,1]
    [Fact]
    public void Test2()
    {
        var head = new ListNode(1, new ListNode(2));
        var expected = new ListNode(2, new ListNode(1));

        var result = _solution.ReverseList(head);

        Assert.Equal(expected.val, result.val);
        Assert.Equal(expected.next.val, result.next.val);
    }

    // Example 3: Input: head = [] Output: []
    [Fact]
    public void Test3()
    {
        ListNode? head = null;
        var result = _solution.ReverseList(head);

        Assert.Null(result);
    }

}