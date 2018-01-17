using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerCsharp.TextManipulation.Exercises
{
    class Exercise4
    {
        public static void Exercise()
        {
            Console.Write("Please enter some words: ");
            string input = Console.ReadLine();

            string[] words = input.Split(' ');
            StringBuilder pascalWord = new StringBuilder();

            foreach (string word in words)
            {

            }

            Console.WriteLine(pascalWord);
        }
    }
}
