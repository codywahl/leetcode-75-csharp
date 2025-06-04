using Xunit;
using LeetCode75.Solutions.LinkedList;

namespace LeetCode75.Tests.LinkedList;

public class MergeTwoSortedListsTests
{
    // example 1:
    // Input: list1 = [1,2,4], list2 = [1,3,4]
    // Output: [1,1,2,3,4,4]

    [Fact]
    public void MergeTwoSortedLists_Example1()
    {
        var list1 = new ListNode21(1, new ListNode21(2, new ListNode21(4)));
        var list2 = new ListNode21(1, new ListNode21(3, new ListNode21(4)));

        var solution = new Solution21();
        var mergedList = solution.MergeTwoLists(list1, list2);

        var expected = new ListNode21(1,
            new ListNode21(1,
            new ListNode21(2,
            new ListNode21(3,
            new ListNode21(4,
            new ListNode21(4))))));

        Assert.Equal(expected.val, mergedList.val);
        Assert.Equal(expected.next.val, mergedList.next.val);
        Assert.Equal(expected.next.next.val, mergedList.next.next.val);
        Assert.Equal(expected.next.next.next.val, mergedList.next.next.next.val);
        Assert.Equal(expected.next.next.next.next.val, mergedList.next.next.next.next.val);
        Assert.Equal(expected.next.next.next.next.next.val, mergedList.next.next.next.next.next.val);
    }


    // Example 2:

    // Input: list1 = [], list2 = []
    // Output: []
    [Fact]
    public void MergeTwoSortedLists_Example2()
    {
        var solution = new Solution21();
        var mergedList = solution.MergeTwoLists(null, null);

        Assert.Null(mergedList);
    }

    // Example 3:

    // Input: list1 = [], list2 = [0]
    // Output: [0]
    [Fact]
    public void MergeTwoSortedLists_Example3()
    {
        var list2 = new ListNode21(0);

        var solution = new Solution21();
        var mergedList = solution.MergeTwoLists(null, list2);

        Assert.NotNull(mergedList);
        Assert.Equal(0, mergedList.val);
        Assert.Null(mergedList.next);
    }
}