using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerCsharp.ControlFlow
{
    public enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }

    public class Conditionals
    {
        public void IfStatements()
        {
            int hour = 10;

            if(hour > 0 && hour < 12)
                Console.WriteLine("It's morning.");
            else if (hour >= 12 && hour < 18)
                Console.WriteLine("It's afternoon.");
            else
                Console.WriteLine("It's midnight.");

            bool isGoldCustomer = true;
            float price = isGoldCustomer ? 19.95f : 29.95f;
            Console.WriteLine(price);

            var season = Season.Autumn;
            switch(season)
            {
                // In this case same code is executed for both cases
                case Season.Autumn:
                case Season.Summer:
                    Console.WriteLine("It's Summer or Autumn.");
                    break;

                case Season.Spring:
                    Console.WriteLine("It's Spring.");
                    break;

                case Season.Winter:
                    Console.WriteLine("It's Winter.");
                    break;

                default:
                    Console.WriteLine("I don't understand that season.");
                    break;  
            }
        }
    }
}
