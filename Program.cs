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
            Console.WriteLine(StringPrograms.ReverseWords("I love Deloitte"));    // Deloitte love I


            // Q5 - CountCharacters - Write a C# method that counts how many times each character
            // appears in a string. Ignore spaces and treat upper/lower case as the same.
            // Return a Dictionary<char, int>.
            // Example: "Sumit Gaware" -> s:1, u:1, m:1, i:1, t:1, g:1, a:2, w:1, r:1, e:1
            var charCounts = StringPrograms.CountCharacters("Sumit Gaware");
            foreach (var key in charCounts)
            {
                Console.WriteLine($"{key.Key}: {key.Value}");
            }

            // Q6 - FirstNonRepeatingChar - Write a C# method that returns the first character in a string
            // that does not repeat anywhere in the string. Ignore case. If every character repeats, return '\0'
            // (or say "none").
            // Example: "swiss" -> 'w'      "Sumit Sumit" -> no unique char -> '\0'
            // Example: "swiss" -> 'w'      "Sumit Sumit" -> no unique char -> '\0'
            Console.WriteLine(StringPrograms.FirstNonRepeatingChar("Swiss"));


            // Q7 - FindDuplicates - Write a C# method that finds all numbers that appear more than once
            // in an integer array. Each duplicate should appear only once in the result.
            // Example: [4, 2, 7, 2, 9, 4, 4] -> [4, 2]
            int[] numbers = { 4, 2, 7, 2, 9, 4, 4 };
            var duplicates =ArrayPrograms.FindDuplicates(numbers);
            Console.WriteLine(string.Join(", ", duplicates)); // Output: 4, 2

            // Q8 - SecondLargest - Write a C# method that returns the second largest number in an integer
            // array WITHOUT sorting and in a single loop. Duplicates of the largest don't count as second.
            // If there is no second largest, return -1 (or say int.MinValue).
            // Example: [10, 5, 20, 8, 20] -> 10
            Console.WriteLine(ArrayPrograms.SecondLargest(new int[] { 10, 5, 20, 8, 20 })); // Output: 10

            // Q9 - TwoSum - You are given an integer array 'nums' and an integer 'target'.
            // Find two numbers in the array that add up to the target, and return their positions
            // (indexes), not the numbers themselves. Each input has exactly one valid solution,
            // and you may not use the same element twice.
            // Example: nums = [2, 7, 11, 15], target = 9 -> [0, 1]  (because 2 + 7 = 9)
            int[] num = { 2, 7, 11, 15 };
            int target = 9;
            var result = ArrayPrograms.TwoSum(num, target);
            Console.WriteLine(string.Join(", ", result));

            // Q10 - FindMissingNumber - An array contains numbers from 1 to n with exactly one number
            // missing (no duplicates, any order). Find the missing number.
            // Example: [1, 2, 4, 5, 6] -> 3
            int[] arr = { 1, 2, 4, 5, 6 };
            Console.WriteLine(ArrayPrograms.FindMissingNumber(arr)); // Output: 3

        }
    }   
}
