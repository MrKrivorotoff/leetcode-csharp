namespace leetcode_csharp.keep_multiplying_found_values_by_two;

public class Solution
{
    public int FindFinalValue(int[] nums, int original) =>
        FindFinalValueUsingHashSet(nums, original);

    private static int FindFinalValueUsingHashSet(int[] nums, int original)
    {
        var setOfNums = new HashSet<int>(nums);
        while (setOfNums.Contains(original))
            original <<= 1;
        return original;
    }

    private static int FindFinalValueUsingSorting(int[] nums, int original)
    {
        Array.Sort(nums);
        foreach (var num in nums)
            if (original == num)
                original <<= 1;
        return original;
    }
}