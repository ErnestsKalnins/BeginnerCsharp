using System;
using BeginnerCsharp.PrimitiveTypesAndExpressions;
using BeginnerCsharp.NonPrimitiveTypes;

namespace BeginnerCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person obj = new Person();
            obj.firstName = "John";
            obj.lastName = "Smith";
            obj.Introduce();

            Calculator calculator = new Calculator();
            int result = calculator.Add(1, 2);
            Console.WriteLine(result);
        }
    }
}
