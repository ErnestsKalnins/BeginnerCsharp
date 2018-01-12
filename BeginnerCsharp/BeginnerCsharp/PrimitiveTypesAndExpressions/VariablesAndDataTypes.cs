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



    }
}
