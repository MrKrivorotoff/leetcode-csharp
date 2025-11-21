namespace leetcode_csharp.number_of_steps_to_reduce_a_number_to_zero;

public class Solution
{
    public int NumberOfSteps(int num)
    {
        var counter = 0;
        var current = num;
        while (current != 0)
        {
            if ((current & 1) == 1)
                current--;
            else
                current >>= 1;
            counter++;
        }
        return counter;
    }
}