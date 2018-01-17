using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerCsharp.ArraysAndLists.Exercises
{
    class Exercise5
    {
        public static void Exercise()
        {
            string numberString = QueryInput("Please enter a list of at least 5 comma seperated numbers: ");

            try
            {
                int[] numbers = StringToIntArray(numberString);
                List<int> numberList = numbers.ToList();

                if (numberList.Count < 5)
                {
                    Console.WriteLine("Invalid list!");
                }
                else
                {
                    numberList.Sort();
                    Console.WriteLine("{0}, {1}, {2}", numberList[0], numberList[1], numberList[2]);
                }
            }
            catch
            {
                Console.WriteLine("The given list contains a symbol or a number, aborting!");
            }
        }

        private static string QueryInput(string query)
        {
            Console.Write(query);
            return Console.ReadLine();
        }

        private static int[] StringToIntArray(string sequence)
        {
            return Array.ConvertAll(sequence.Split(','), int.Parse);
        }
    }
}
