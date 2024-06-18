public class AnagramChecker
{
    public static bool AreAnagrams(string str1, string str2)
    {
        return true;
    }

    public static void Main(string[] args)
    {
        // Test the AreAnagrams function
        Console.WriteLine("Enter the first string:");
        string input1 = Console.ReadLine();

        Console.WriteLine("Enter the second string:");
        string input2 = Console.ReadLine();

        if (AreAnagrams(input1, input2))
        {
            Console.WriteLine("They are anagrams!");
        }
        else
        {
            Console.WriteLine("They are not anagrams.");
        }
    }
}