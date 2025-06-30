[334\. Increasing Triplet Subsequence](https://leetcode.com/problems/increasing-triplet-subsequence/)

Medium

Topics

![premium lock icon](https://leetcode.com/_next/static/images/lock-a6627e2c7fa0ce8bc117c109fb4e567d.svg)Companies

Given an integer array `nums`, return `true`_ if there exists a triple of indices _`(i, j, k)`_ such that _`i < j < k`_ and _`nums[i] < nums[j] < nums[k]`. If no such indices exists, return `false`.

Example 1:

Input: nums = [1,2,3,4,5]
Output: true
Explanation: Any triplet where i < j < k is valid.

Example 2:

Input: nums = [5,4,3,2,1]
Output: false
Explanation: No triplet exists.

Example 3:

Input: nums = [2,1,5,0,4,6]
Output: true
Explanation: The triplet (3, 4, 5) is valid because nums[3] == 0 < nums[4] == 4 < nums[5] == 6.

Constraints:

- `1 <= nums.length <= 5 * 10^5`
- `-2^31 <= nums[i] <= 2^31 - 1`
