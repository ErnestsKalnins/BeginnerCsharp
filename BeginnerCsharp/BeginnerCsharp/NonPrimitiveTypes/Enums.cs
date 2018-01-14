using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerCsharp.NonPrimitiveTypes
{
    /** 
     * By default uses an int value. 
     * Used type can be changed by declaring enum like this:
     * public enum EnumName : byte
     */
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }

    public class Enums
    {
        public void EnumMethod()
        {
            ShippingMethod method = ShippingMethod.Express;
            Console.WriteLine(method);
            Console.WriteLine((int)method);

            // converting int to enum
            int methodId = 3;
            //Console.WriteLine((ShippingMethod)methodId);

            // Console.WriteLine does the below ToString method on values passed in by default.
            //Console.WriteLine(method.ToString());

            // Parsing - getting a string and converting it to a different type.
            string methodName = "Express";
            var shippingMethod = Enum.Parse(typeof(ShippingMethod), methodName);
            Console.WriteLine(shippingMethod);
        }
    }
}
