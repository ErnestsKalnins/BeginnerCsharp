using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerCsharp.PrimitiveTypesAndExpressions
{
    class TypeConversion
    {
        public void ImplicitExplicitConversion()
        {
            byte b = 1;
            int i = b;
            Console.WriteLine(i);

            int c = 1000;
            byte d = (byte) c;
            Console.WriteLine(d);
        }

        public void NonCompatibleTypes()
        {
            string number = "1234";
            // int i = (int) number; - can't do this.
            //int i = Convert.ToInt32(number);

            // Exception handling, doesn't cause a crash.
            try
            {
                // Causes an overflow, because 1234 is greater than 256.
                byte i = Convert.ToByte(number);
                Console.WriteLine(i);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte.");
            }
        }
    }
}
