using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerCsharp.ControlFlow
{
    public class RNG
    {
        public void Random()
        {
            const int passwordLength = 10;
            // Random generates a random number.
            var random = new Random();

            char[] buffer = new char[passwordLength];
            for (int i = 0; i < passwordLength; i++)
                buffer[i] = (char)('a' + random.Next(0, 26));

            string password = new string(buffer);
            Console.WriteLine(password);
        }
    }
}
