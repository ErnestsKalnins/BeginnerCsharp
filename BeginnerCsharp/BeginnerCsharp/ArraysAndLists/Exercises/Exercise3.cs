using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerCsharp.ArraysAndLists.Exercises
{
    class Exercise3
    {
        public static void Exercise()
        {
            List<int> numbers = new List<int>();
            int currentNumber;

            while (numbers.Count < 5)
            {
                try
                {
                    currentNumber = QueryNewNumber("Please enter a number: ");

                    if (NumberExistsInList(currentNumber, numbers))
                    {
                        Console.WriteLine("Number already exists in the list, try again!");
                    }
                    else
                    {
                        numbers.Add(currentNumber);
                    }
                }
                catch (ArgumentException exception)
                {
                    Console.WriteLine("Invalid input, try again!");
                    /**
                     * Use the exception variable to log to a logfile or something else,
                     * don't display it openly.
                     * 
                     * Console.WriteLine(exception.ParamName);
                     */
                }
            }

            numbers.Sort();
            Console.WriteLine(string.Join(" ", numbers));
        }

        private static int QueryNewNumber(string query)
        {
            int inputNumber;

            Console.Write(query);

            if (!int.TryParse(Console.ReadLine(), out inputNumber))
                throw new ArgumentException("Input was not a number.", "inputNumber");

            return inputNumber;
        }

        private static bool NumberExistsInList(int needle, List<int> haystack)
        {
            return haystack.IndexOf(needle) >= 0;
        }
    }
}
