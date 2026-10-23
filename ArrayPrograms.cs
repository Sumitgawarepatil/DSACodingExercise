using System;
using System.Collections.Generic;
using System.Text;

namespace DSACodingExercise
{
    internal class ArrayPrograms
    {

        public static List<int> FindDuplicates(int[] numbers)
        {
            HashSet<int> seenNumbers = new HashSet<int>();
            HashSet<int> duplicates = new HashSet<int>();

            foreach (int number in numbers)
            {
                if (seenNumbers.Contains(number))
                {
                    duplicates.Add(number);
                }
                else
                {
                    seenNumbers.Add(number);
                }

            }

            return new List<int>(duplicates);
        }

        public static int SecondLargest(int[] numbers)
        {
            if (numbers == null || numbers.Length < 2) return -1;

            int largest = int.MinValue;
            int second = int.MinValue;

            foreach (int n in numbers)
            {
                if (n > largest)              // new biggest found
                {
                    second = largest;         // old biggest becomes second
                    largest = n;
                }
                else if (n > second && n != largest)   // between second and largest
                {
                    second = n;
                }
            }

            return second == int.MinValue ? -1 : second;
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            if (nums == null || nums.Length < 2) return new int[0];

            Dictionary<int, int> numToIndex = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];

                if (numToIndex.ContainsKey(complement))       // 1. CHECK first
                {
                    return new int[] { numToIndex[complement], i };
                }

                numToIndex[nums[i]] = i;                      // 2. then STORE (outside the if)
            }

            return new int[0];                                // 3. AFTER the loop ends
        }
    }
}
