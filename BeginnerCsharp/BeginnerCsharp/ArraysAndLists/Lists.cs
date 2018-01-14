using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerCsharp.ArraysAndLists
{
    class Lists
    {
        public void ListMethods()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4 };

            // Adding an element
            numbers.Add(1);
            numbers.AddRange(new int[3] { 5, 6, 7 });

            foreach (int number in numbers)
                Console.WriteLine(number);

            Console.WriteLine();

            // Finding indexes
            Console.WriteLine("Index of 1 : " + numbers.IndexOf(1));
            Console.WriteLine("Last index of 1 : " + numbers.LastIndexOf(1));
            Console.WriteLine();
            // Getting size
            Console.WriteLine("Count: " + numbers.Count);
            Console.WriteLine();
            // Removing
            numbers.Remove(1);

            /** 
             * The below method of removing elements cannot be done in a foreach loop,
             * because it modifies it. Instead use for loop.
             */ 
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                {
                    numbers.Remove(1);
                }
            }

            Console.WriteLine("Effect of Remove()");
            foreach (int number in numbers)
                Console.WriteLine(number);

            // Clear
            numbers.Clear();

            Console.WriteLine("Effect of Clear()");
            Console.WriteLine("Count: " + numbers.Count);
        }
    }
}
