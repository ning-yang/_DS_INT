//  https://leetcode.com/problems/sliding-window-maximum/
//  
//  Given an array nums, there is a sliding window of size k which is moving from the very left of the array to the very right. You can only see the k numbers in the window. Each time the sliding window moves right by one position.
//  
//  For example,
//  Given nums = [1,3,-1,-3,5,3,6,7], and k = 3.
//  
//  Window position                Max
//  ---------------               -----
//  [1  3  -1] -3  5  3  6  7       3
//   1 [3  -1  -3] 5  3  6  7       3
//   1  3 [-1  -3  5] 3  6  7       5
//   1  3  -1 [-3  5  3] 6  7       5
//   1  3  -1  -3 [5  3  6] 7       6
//   1  3  -1  -3  5 [3  6  7]      7
//  Therefore, return the max sliding window as [3,3,5,5,6,7].
//  
//  Note: 
//  You may assume k is always valid, ie: 1 ≤ k ≤ input array's size for non-empty array.
//  
//  Follow up:
//  Could you solve it in linear time?

public class Solution
{
    public int[] MaxSlidingWindow(int[] nums, int k)
    {
        LinkedList<int> queue = new LinkedList<int>();
        List<int> result = new List<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            while (queue.Count != 0 && nums[queue.Last.Value] < nums[i]) queue.RemoveLast();

            queue.AddLast(i);

            if ((i - queue.First.Value) >= k)
            {
                queue.RemoveFirst();
            }

            if (i >= (k - 1))
            {
                result.Add(nums[queue.First.Value]);
            }
        }

        return result.ToArray();
    }
}