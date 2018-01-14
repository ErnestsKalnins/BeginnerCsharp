using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerCsharp.TextManipulation
{
    public class Strings
    {
        public void Methods()
        {
            string fullName = "Ernests Kalnins ";
            Console.WriteLine("Normal: '{0}'", fullName);
            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("First Name: {0}, Last Name: {1}", firstName, lastName);

            string[] names = fullName.Split(' ');
            Console.WriteLine("First Name: {0}, Last Name: {1}", names[0], names[1]);

            Console.WriteLine(fullName.Replace("Ernests", "Everests"));

            if (string.IsNullOrWhiteSpace(" "))
                Console.WriteLine("Invalid");

            string number = "25";
            byte age = Convert.ToByte(number);
            Console.WriteLine(age);

            float price = 29.95f;
            Console.WriteLine(price.ToString("C"));
        } 
    } 
}
