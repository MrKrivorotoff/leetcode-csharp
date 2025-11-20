namespace leetcode_csharp.keep_multiplying_found_values_by_two;

public class Solution
{
    public int FindFinalValue(int[] nums, int original)
    {
        var setOfNums = new HashSet<int>(nums);
        while (setOfNums.Contains(original))
            original <<= 1;
        return original;
    }
}