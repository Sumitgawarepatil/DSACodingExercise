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
    }
}
