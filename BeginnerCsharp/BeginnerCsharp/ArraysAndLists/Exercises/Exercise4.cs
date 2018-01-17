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

                if (buffer.ToLower() == "quit")
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

                Console.WriteLine(string.Join(", ", GetUniqueNumbers(numbers)));
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

        private static List<int> GetUniqueNumbers(List<int> numberArray)
        {
            List<int> uniqueNumbers = new List<int>();

            foreach (int number in numberArray)
            {
                if (!uniqueNumbers.Contains(number))
                    uniqueNumbers.Add(number);

            }

            return uniqueNumbers;
        }
    }
}
