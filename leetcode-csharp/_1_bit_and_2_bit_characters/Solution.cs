namespace leetcode_csharp._1_bit_and_2_bit_characters;

public class Solution
{
    public bool IsOneBitCharacter(int[] bits)
    {
        var numberOfBits = -1;
        var bitsLength = bits.Length;
        for (var i = 0; i < bitsLength;) {
            numberOfBits = (bits[i] == 1) ? 2 : 1;
            i += numberOfBits;
        }
        return numberOfBits == 1;
    }
}