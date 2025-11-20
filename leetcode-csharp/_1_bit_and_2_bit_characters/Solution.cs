namespace leetcode_csharp._1_bit_and_2_bit_characters;

public class Solution
{
    public bool IsOneBitCharacter(int[] bits)
    {
        var i = 0;
        var bitsLength = bits.Length;
        while (i < bitsLength - 1)
            i += bits[i] + 1;
        return i == bitsLength - 1;
    }
}