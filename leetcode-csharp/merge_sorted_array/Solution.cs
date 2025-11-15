namespace leetcode_csharp.merge_sorted_array;

public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        var result = new int[nums1.Length];
        for (int i = 0, j = 0, k = 0; i < m || j < n; k++)
        {
            var num1 = i < m ? nums1[i] : int.MaxValue;
            var num2 = j < n ? nums2[j] : int.MaxValue;
            if (num1 < num2)
            {
                result[k] = num1;
                i++;
            }
            else
            {
                result[k] = num2;
                j++;
            }
        }
        Array.Copy(result, nums1, m + n);
    }
}