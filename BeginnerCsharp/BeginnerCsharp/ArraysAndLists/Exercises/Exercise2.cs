using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerCsharp.ArraysAndLists.Exercises
{
    class Exercise2
    {
        public static void Exercise()
        {
            string name;
            Console.Write("Please enter your name: ");
            name = Console.ReadLine();

            string reversedName = ReverseString(name);

            Console.WriteLine(reversedName);
        }

        private static string ReverseString(string word)
        {
            char[] buffer = new char[word.Length];

            for (int i = word.Length; i > 0; i--)
                buffer[word.Length - i] = word[i - 1];

            return new string(buffer);
        }
    }
}
