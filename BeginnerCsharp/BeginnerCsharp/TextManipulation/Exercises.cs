using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerCsharp.TextManipulation
{
    // Todo
    public class Exercises
    {
        public static void Exercise1()
        {
            Console.WriteLine("Input a series of hyphen seperated numbers : ");
            string inputString = Console.ReadLine();
            int[] numbers = Array.ConvertAll(inputString.Split('-'), int.Parse);
            
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[i - 1])
                {
                    Console.WriteLine("Not consecutive!");
                    break;
                }
                else if (i == numbers.Length - 1)
                {
                    Console.WriteLine("Consecutive!");
                }
            }
        }

        public static void CheckIfConsecutive(int[] array)
        {
            
        }
    }
}
