namespace DSACodingExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Q1 - ReverseString - Write a C# method that reverses a given string without using
            // built-in methods like Array.Reverse() or LINQ Reverse(). Handle null and empty input.
            // Example: "Sumit" -> "timuS"
            Console.WriteLine(StringPrograms.ReverseString("SumitGaware"));    // erawaGtimuS

            // Q2 - IsPalindrome - Write a C# method that checks whether a string is a palindrome.
            // A palindrome reads the same forwards and backwards. The check should ignore upper/lower case.
            // Return true if it is a palindrome, otherwise false.
            // Example: "Madam" -> true, "Sumit" -> false
            Console.WriteLine(StringPrograms.IsPalindrome("Madam"));            // True
            Console.WriteLine(StringPrograms.IsPalindrome("Sumit"));            // False

            // Q3 - IsAnagram - Write a C# method that checks whether two strings are anagrams of each other.
            // Two strings are anagrams if they contain the same characters with the same frequency, in any order.
            // The check should ignore upper/lower case. Return true if they are anagrams, otherwise false.
            // Example: "listen", "silent" -> true
            Console.WriteLine(StringPrograms.IsAnagram("listen", "silent"));    // True
            Console.WriteLine(StringPrograms.IsAnagram("Earth", "Heart"));      // True
            Console.WriteLine(StringPrograms.IsAnagram("hello", "world"));      // False
            Console.WriteLine(StringPrograms.IsAnagram("listen", "sumit"));     // False


            // Q4 - ReverseWords - Write a C# method that reverses the order of the words in a sentence.
            // The words themselves should not be reversed, only their order. Handle extra spaces.
            // Example: "I love Deloitte" -> "Deloitte love I"
        }
    }
}
