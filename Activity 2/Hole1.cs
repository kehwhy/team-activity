namespace CodeGolf;

// Problem Statement
// Given a string s, write a function that returns the string in reverse order.
//
// Example
// For example, given the string "hello", the reversed string is "olleh".
//
// Constraints
// The function should work for any string s (0 ≤ s.length ≤ 100).

public class Hole1 {
    [Theory]
    [InlineData("hello", "olleh")]
    [InlineData("world", "dlrow")]
    [InlineData("a", "a")]
    [InlineData("", "")]
    [InlineData("racecar", "racecar")]
    [InlineData("12345", "54321")]
    [InlineData("!@#$%", "%$#@!")]
    public void Test_ReverseString(string input, string expected)
    {
        // Act
        string actual = ReverseString(input);

        // Assert
        Assert.Equal(expected, actual);
    }

    string ReverseString(string s) {
        return "";
    }
}