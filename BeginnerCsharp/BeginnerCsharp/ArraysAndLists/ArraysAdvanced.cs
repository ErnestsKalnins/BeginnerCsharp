using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerCsharp.ArraysAndLists
{
    public class ArraysAdvanced
    {
        public void ArrayMethods()
        {
            int[] numbers = new int[] { 3, 7, 9, 2, 14, 6 };

            // Length
            Console.WriteLine("Length : " + numbers.Length);

            // IndexOf
            int index = Array.IndexOf(numbers, 9);
            Console.WriteLine("Index of 9 : " + index);

            // Clear
            Array.Clear(numbers, 0, 2);

            Console.WriteLine("Effect of Clear()");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            // Copy
            int[] anotherArray = new int[3];
            Array.Copy(numbers, anotherArray, 3);

            Console.WriteLine("Effect of Copy()");
            foreach (int number in anotherArray)
            {
                Console.WriteLine(number);
            }

            // Sort
            Array.Sort(numbers);

            Console.WriteLine("Effect of Sort()");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            // Reverse
            Array.Reverse(numbers);

            Console.WriteLine("Effect of Reverse()");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
