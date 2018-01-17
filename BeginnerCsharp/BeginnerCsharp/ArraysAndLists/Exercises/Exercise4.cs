using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerCsharp.ArraysAndLists.Exercises
{
    class Exercise4
    {
        public static void Exercise()
        {
            List<int> numbers = new List<int>();
            int currentNumber;
            string buffer;

            while (true)
            {
                buffer = QueryInput("Please enter a number: ");

                if (buffer == "Quit")
                    break;

                try
                {
                    currentNumber = VerifyInputValid(buffer);
                    numbers.Add(currentNumber);
                }
                catch
                {
                    Console.WriteLine("Invalid input, try again!");
                }

                List<int> displayNumbers = new List<int>();

                for (int i = 0; i < numbers.Count; i++)
                {
                    if (NumberExistsInList(numbers[i], displayNumbers))
                    {
                        continue;
                    }
                    else
                    {
                        displayNumbers.Add(numbers[i]);
                    }
                }

                Console.WriteLine(string.Join(", ", displayNumbers));
            }
        }

        private static string QueryInput(string query)
        {
            Console.Write(query);
            return Console.ReadLine();
        }

        private static int VerifyInputValid(string inputString)
        {
            int inputNumber;

            if (!int.TryParse(inputString, out inputNumber))
                throw new ArgumentException("Input was not a number.", "inputString");

            return inputNumber;
        }

        private static bool NumberExistsInList(int needle, List<int> haystack)
        {
            return haystack.IndexOf(needle) >= 0;
        }
    }
}
