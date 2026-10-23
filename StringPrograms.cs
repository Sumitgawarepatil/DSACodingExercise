using System;
using System.Collections.Generic;
using System.Text;

namespace DSACodingExercise
{
    internal class StringPrograms
    {
        public static string ReverseString(string name)
        {
            if (string.IsNullOrEmpty(name))
                return name;
            char[] chararray = name.ToCharArray();
            int n = chararray.Length - 1;
            string temp = "";

            for (int i = 0; i < chararray.Length; i++)
            {
                temp += chararray[n];
                n--;
            }

            return temp;    
        }

        public static bool IsPalindrome(string name)
        {
            bool result = false;
            if (string.IsNullOrEmpty(name))
                return false;
      
            string reversedstring = ReverseString(name);
            return (name.ToLower() == reversedstring.ToLower());
              
        }
        public static bool IsAnagram(string name1 ,  string name2)
        {
            char[] char1 = name1.ToLower().ToCharArray();
            char[] char2 = name2.ToLower().ToCharArray();
            Array.Sort(char1);
            Array.Sort(char2);  

            string sortedname1 = new string(char1);
            string sortedname2 = new string(char2);
            return sortedname1 == sortedname2;
        }

        public static string ReverseWords(string sentence)
        {
            if (string.IsNullOrEmpty(sentence))
                return sentence;
            string[] words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = words.Length - 1; i >= 0; i--)
            {
                stringBuilder.Append(words[i]);
                if (i > 0)
                    stringBuilder.Append(' ');
            }
            return stringBuilder.ToString();
        }
        public  static Dictionary<char , int> CountCharacters(string input)
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (char c in input.ToLower())
            {
                if (c != ' ')
                {
                    if (charCount.ContainsKey(c))
                    {
                        charCount[c]++;
                    }
                    else
                    {
                        charCount[c] = 1;
                    }
                
                }
            }
            return charCount;
        }

        public static char FirstNonRepeatingChar(string input)
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();
            foreach (char c in input.ToLower())
            {
                if (c != ' ')
                {
                    if (charCount.ContainsKey(c))
                    {
                        charCount[c]++;
                    }
                    else
                    {
                        charCount[c] = 1;
                    }
                }
            }
            foreach (char c in input.ToLower())
            {
                if (c != ' ' && charCount[c] == 1)
                {
                    return c;
                }
            }
            return '\0'; // Return '\0' if no non-repeating character is found
        }

    }
}
