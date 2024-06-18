namespace CodeGolf;

// Problem Statement
// Given a list of strings, calculate the size of the largest anagrams group. An anagram is a word or phrase formed by rearranging the letters of a different word or phrase, using all the original letters exactly once.
//
// Example
// For example, given the list ["eat", "tea", "tan", "ate", "nat", "bat"], the anagram groups are ["eat", "tea", "ate"], ["tan", "nat"], and ["bat"] and the size of the largest group is 3.
//
// Constraints
// The function should work for any list of strings (0 ≤ number of strings ≤ 1000, 0 ≤ length of each string ≤ 100)

public class Hole3 {
    
    [Theory]
    [InlineData(new string[] { "eat", "tea", "tan", "ate", "nat", "bat" }, 3)]
    [InlineData(new string[] { "" }, 0)]
    [InlineData(new string[] { "a" }, 1)]
    [InlineData(new string[] { "abc", "bca", "cab", "bac", "acb", "cba" }, 6)]
    [InlineData(new string[] { "listen", "silent", "enlist" }, 3)]
    public void Test_GroupAnagrams(string[] input, int expected)
    {
        // Act
        var actual = GroupAnagrams(new List<string>(input));

        
        Assert.Equal(expected, actual);
    }

    int  GroupAnagrams(List<string> strs)
    {
        return 0;
    }
}