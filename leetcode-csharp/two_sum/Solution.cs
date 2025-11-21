namespace leetcode_csharp.two_sum;

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var cachedIndexByNum = new Dictionary<int, int>();
        var numsLength = nums.Length;
        for (var i = 0; i < numsLength; i++)
        {
            var current = nums[i];
            if (cachedIndexByNum.TryGetValue(target - current, out var cachedIndex))
                return [cachedIndex, i];
            cachedIndexByNum[current] = i;
        }
        throw new ArgumentException(null);
    }
}