namespace leetcode_csharp.ransom_note;

public class Solution
{
    public bool CanConstruct(string ransomNote, string magazine) {
        var numberByLetter = new Dictionary<char, int>();
        foreach (var currentLetter in magazine)
        {
            var number = numberByLetter.GetValueOrDefault(currentLetter, 0);
            numberByLetter[currentLetter] = number + 1;
        }
        foreach (var currentLetter in ransomNote)
        {
            var number = numberByLetter.GetValueOrDefault(currentLetter, 0);
            if (number == 0)
                return false;
            numberByLetter[currentLetter] = number - 1;
        }
        return true;
    }
}