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
    }
}
