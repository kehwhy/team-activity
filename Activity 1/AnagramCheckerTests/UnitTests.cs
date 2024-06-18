using System;
using Xunit;

public class AnagramCheckerTests
{
    [Theory]
    [InlineData("listen", "silent", true)]
    [InlineData("hello", "worlds", false)]
    [InlineData("hello", "world", false)]
    [InlineData("Listen", "silent", true)]
    [InlineData("Listen", "Silent", true)]
    [InlineData("", "", true)]
    [InlineData("abc", "def", false)]
    [InlineData("conversation", "voices rant on", true)]
    [InlineData("pug", "guppy", false)]
    [InlineData("A man, a plan, a canal: Panama", "A Panama canal, a plan, a man", false)]
    public void AnagramChecker_TestCases(string str1, string str2, bool expectedResult)
    {
        Assert.Equal(expectedResult, AnagramChecker.AreAnagrams(str1, str2));
    }
}