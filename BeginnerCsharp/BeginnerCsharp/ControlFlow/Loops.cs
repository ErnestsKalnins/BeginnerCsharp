using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerCsharp.ControlFlow
{
    public class Loops
    {
        public void ForLoop()
        {
            for (var i = 0; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public void ForEachLoop()
        {
            string name = "John Smith";
            foreach (char character in name)
            {
                Console.WriteLine(character);
            }

            int[] numbers = new int[] { 1, 2, 3, 4 };
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        public void WhileLoop()
        {
            int i = 0;
            while (i <= 10)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);

                i++;
            }

            while(true)
            {
                Console.Write("Type your name: ");
                string input = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine(input);
                    continue;
                }

                break;
            }
        }
    }
}
