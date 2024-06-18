namespace CodeGolf;

// Problem Statement
// Given a positive integer n, write a function that calculates the sum of its digits.
//
// Example
// For example, given the number 𝑛 = 12345, the sum of its digits is 1+2+3+4+5=15.
//
// Constraints
// The function should work for any positive integer n (1 ≤ n ≤ 10^6).

public class Hole2 {
    [Theory]
    [InlineData(7, 7)]
    [InlineData(12345, 15)]
    [InlineData(1111, 4)]
    [InlineData(987654, 39)]
    [InlineData(9, 9)]
    [InlineData(1000000, 1)]
    public void Test_SumOfDigits(int input, int expected)
    {
        // Act
        int actual = SumOfDigits(input);

        // Assert
        Assert.Equal(expected, actual);
    }
    
    int SumOfDigits(int n) {
        return 0;
    }
}