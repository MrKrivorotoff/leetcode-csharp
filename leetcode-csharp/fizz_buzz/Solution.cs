namespace leetcode_csharp.fizz_buzz;

public class Solution
{
    public IList<string> FizzBuzz(int n) => FizzBuzzUsingSimpleIteration(n);

    private static IList<string> FizzBuzzUsingLinq(int number) => Enumerable
        .Range(1, number)
        .Select(SelectFizzBuzzOrNumber)
        .ToList();

    private static IList<string> FizzBuzzUsingSimpleIteration(int number)
    {
        var result = new List<string>(number);
        for (var i = 1; i <= number; i++)
            result.Add(SelectFizzBuzzOrNumber(i));
        return result;
    }

    private static string SelectFizzBuzzOrNumber(int number)
    {
        var divisibleBy3 = number % 3 == 0;
        var divisibleBy5 = number % 5 == 0;
        
        if (divisibleBy3 && divisibleBy5)
            return "FizzBuzz";
        if (divisibleBy3)
            return "Fizz";
        if (divisibleBy5)
            return "Buzz";
        return number.ToString();
    }
}