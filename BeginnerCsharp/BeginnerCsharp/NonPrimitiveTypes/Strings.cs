using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerCsharp.NonPrimitiveTypes
{
    public class Strings
    {
        public void StringCreation()
        {
            string firstName = "John";
            string lastName = "Doe";

            string fullName = firstName + " " + lastName;

            string myFullName = string.Format("My name is {0} {1}", firstName, lastName);

            string[] names = new string[3] { "Joe", "Pete", "Mary" };
            string formattedNames = string.Join(", ", names);

            // Verbatim strings. WYSIWYG, basically.
            string text = @"Hi, John
Look into the following paths
c:\folder1\folder2
c:\folder3\folder4";
            Console.WriteLine(text);
        }
    }
}
