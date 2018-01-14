using System;
using BeginnerCsharp.PrimitiveTypesAndExpressions;
using BeginnerCsharp.NonPrimitiveTypes;
using BeginnerCsharp.ControlFlow;
using BeginnerCsharp.ArraysAndLists;
using BeginnerCsharp.TextManipulation;

namespace BeginnerCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "This is a really long text that i wrote for the purpose of testing this method.";
            string summary = Summariser.Summary(text, 40);
            Console.WriteLine(summary);
        }
    }
}
