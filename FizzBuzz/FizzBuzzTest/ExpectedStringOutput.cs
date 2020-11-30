namespace FizzBuzzTest
{
    public static class ExpectedStringOutput
    {
        internal static string ExpectedFizzBuzzOutput { get; } =
@"1
2
Fizz
4
Buzz
";

        internal static string ExpectedFizzBuzzLengthOutput { get; } =
            @"Please write a number between 1-300 and press enter: Incorrect input! Please try again: ";
    }
}
