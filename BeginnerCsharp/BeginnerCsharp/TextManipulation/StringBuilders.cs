using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerCsharp.TextManipulation
{
    class StringBuilders
    {
        public static void Methods()
        {
            StringBuilder builder = new StringBuilder("Hello World");

            // Append string n times
            builder
                .Append('-', 10)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10);

            Console.WriteLine(builder);

            // Replace
            builder.Replace('-', '+');

            Console.WriteLine(builder);

            // Remove
            builder.Remove(0, 10);
            Console.WriteLine(builder);

            // Insert at specific index
            builder.Insert(0, new string('-', 10));
            Console.WriteLine(builder);

            Console.WriteLine("First char : " + builder[0]);
        }
    }
}
