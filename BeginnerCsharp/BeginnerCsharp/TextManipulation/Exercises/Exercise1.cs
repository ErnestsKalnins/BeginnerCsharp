using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerCsharp.TextManipulation.Exercises
{
    class Exercise1
    {
        public static void Exercise()
        {
            Console.WriteLine("Input a series of hyphen seperated numbers : ");
            string inputString = Console.ReadLine();
            int[] numbers = StringToIntArray(inputString);

            if (IsArrayAscending(numbers) || IsArrayDescending(numbers))
            {
                Console.WriteLine("Consecutive");
            }
            else
            {
                Console.WriteLine("Not consecutive.");
            }
        }

        private static bool IsArrayAscending(int[] numberArray)
        {
            int[] sortedArray = new int[numberArray.Length]; 
            Array.Copy(numberArray, sortedArray, numberArray.Length);
            Array.Sort(sortedArray);

            return ArraysEqual(sortedArray, numberArray);
        }

        private static bool IsArrayDescending(int[] numberArray)
        {
            int[] sortedArray = new int[numberArray.Length];
            Array.Copy(numberArray, sortedArray, numberArray.Length);
            Array.Sort(sortedArray);
            Array.Reverse(sortedArray);

            return ArraysEqual(sortedArray, numberArray);
        }

        private static bool ArraysEqual(int[] arrayOne, int[] arrayTwo)
        {
            for (int i = 1; i < arrayTwo.Length; i++)
            {
                if (arrayOne[i] != arrayTwo[i])
                    return false;
            }
            return true;
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
    }
}
