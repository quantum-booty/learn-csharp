using System;
using System.Collections.Generic;

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var remainder = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (remainder.ContainsKey(nums[i]))
            {
                return new int[] { i, remainder[nums[i]] };
            }
            remainder[target - nums[i]] = i;
        }
        return new int[] { };
    }

    static void Main(string[] args)
    {
    }
}
