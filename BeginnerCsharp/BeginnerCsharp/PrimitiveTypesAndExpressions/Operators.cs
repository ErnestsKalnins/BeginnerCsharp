using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerCsharp.PrimitiveTypesAndExpressions
{
    class Operators
    {
        public void Arithmetic()
        {
            int a = 10;
            int b = 3;
            // The division below equals 3, because the data types are integers. They need to be casted.
            //Console.WriteLine(a/b);
            Console.WriteLine((float)a / b);
        }

        public void Comparison()
        {
            int a = 10;
            int b = 3;

            Console.WriteLine(a > b);
            Console.WriteLine(!(a != b));
        }

        public void Logic()
        {
            int a = 1;
            int b = 2;
            int c = 3;

            Console.WriteLine(c > b && c > a);
            Console.WriteLine(c > b && c == a);
            Console.WriteLine(c > b || c == a);
        }
    }
}
