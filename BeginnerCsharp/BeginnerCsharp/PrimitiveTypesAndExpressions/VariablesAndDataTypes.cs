using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerCsharp.PrimitiveTypesAndExpressions
{
    public class VariablesAndDataTypes
    {

        public void Overflowing()
        {
            /**
             * Checks if a variable overflows. If that is the case, throws error and
             * ceases execution.
             */
            checked
            {
                byte number = 255;
                number += 1;
            }
        }

        public void VariablesAndConstants()
        {
            // Keyword 'var' automatically resolves the used data type.
            //byte number = 2;
            var number = 2;
            //int count = 10;
            var count = 10;
            //float totalPrice = 20.95f;
            var totalPrice = 20.95f;
            //char character = 'A';
            var character = 'A';
            //string firstName = "Ernests";
            var firstName = "Ernests";
            //bool isWorking = true;
            var isWorking = true;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
        }

        public void WriteWithPlaceholders()
        {
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);
        }

        public void Constants()
        {
            // Can't change constant values.
            const float PI = 3.14f;
        }

    }
}
