using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerCsharp.TextManipulation.Exercises
{
    class Exercise2
    {
        public static void Exercise()
        {
            Console.WriteLine("Input a series of hyphen seperated numbers : ");
            string inputString = Console.ReadLine();

            if (string.IsNullOrEmpty(inputString))
                throw new ArgumentNullException();
                

            List<int> numbers = new List<int>(StringToIntArray(inputString));

            List<int> uniqueNumbers = new List<int>();

            foreach (int number in numbers)
            {
                if (NumberExistsInList(number, uniqueNumbers))
                {
                    Console.WriteLine("Duplicate!");
                    break;
                }
                else
                {
                    uniqueNumbers.Add(number);
                }
            }
        }

        private static int[] StringToIntArray(string input)
        {
            try
            {
                return Array.ConvertAll(input.Split('-'), int.Parse);
            }
            catch
            {
                Console.WriteLine("Invalid input, aborting!");
                return new int[0];
            }
        }

        private static bool NumberExistsInList(int needle, List<int> haystack)
        {
            return haystack.IndexOf(needle) >= 0;
        }
    }
}
