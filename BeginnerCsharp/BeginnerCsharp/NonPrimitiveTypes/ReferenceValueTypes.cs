using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerCsharp.NonPrimitiveTypes
{
    public class ReferenceValueTypes
    {
        public void RefValTyp()
        {
            // the value of 'a' does not change if the value of 'b' gets changed. These are value types.
            var a = 10;
            var b = a;
            b++;
            Console.WriteLine(string.Format("a:{0} b:{1}", a, b));

            int[] array1 = new int[3] { 1, 2, 3};
            int[] array2 = array1;
            array2[0] = 0;

            /** 
             * The value change of one array impacts the other, because both arrays 
             * point to the same memory address of the heap.
             */ 
            Console.WriteLine(string.Format("array1[0]: {0}, array2[0]: {1}", array1[0], array2[0]));
        }
    }
}
