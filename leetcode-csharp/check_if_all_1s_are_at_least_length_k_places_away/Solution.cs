namespace leetcode_csharp.check_if_all_1s_are_at_least_length_k_places_away;

public class Solution
{
    public bool KLengthApart(int[] nums, int k)
    {
        var numsLength = nums.Length;
        for (int i = 0, lastIndOf1 = -1; i < numsLength; i++)
            if (nums[i] == 1)
            {
                if (lastIndOf1 != -1 && (i - lastIndOf1) <= k)
                    return false;
                lastIndOf1 = i;
            }
        return true;
    }
}