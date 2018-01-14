using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerCsharp.ControlFlow
{
    public class Exercises
    {
        public void Exercise1()
        {
            int number;
            Console.Write("Please enter a number between 1 and 10 : ");
            number = int.Parse(Console.ReadLine());

            if(number >= 1 && number <= 10)
            {
                Console.WriteLine("Valid!");
            }
            else
            {
                Console.WriteLine("Invalid!");
            }
        }

        public void Exercise2()
        {
            int numberOne, numberTwo;
            Console.Write("Please enter the first number : ");
            numberOne = int.Parse(Console.ReadLine());
            Console.Write("Please enter the second number : ");
            numberTwo = int.Parse(Console.ReadLine());

            if (numberOne > numberTwo)
            {
                Console.WriteLine(numberOne);
            }
            else
            {
                Console.WriteLine(numberTwo);
            }
        }

        public void Exercise3()
        {
            int width, height;
            Console.Write("Please enter the width : ");
            width = int.Parse(Console.ReadLine());
            Console.Write("Please enter the height : ");
            height = int.Parse(Console.ReadLine());

            if (width > height)
            {
                Console.WriteLine("The canvas is a landscape.");
            }
            else
            {
                Console.WriteLine("The canvas is a portrait.");
            }
        }

        public void Exercise4()
        {
            int speedLimit, speed, demeritPoints;
            Console.Write("Please enter the speed limit : ");
            speedLimit = int.Parse(Console.ReadLine());
            Console.Write("Please enter the vehicles speed : ");
            speed = int.Parse(Console.ReadLine());

            if (speedLimit > speed)
            {
                Console.WriteLine("Ok!");
            }
            else
            {
                int delta = speed - speedLimit;

                for (demeritPoints = 1; delta > 0; demeritPoints++)
                {
                    Console.WriteLine("Demerit Points: {0}", demeritPoints);
                    delta -= 5;
                }
                if (demeritPoints >= 12)
                    Console.WriteLine("License suspended!");
            }
        }

       public void Exercise5()
        {
            int incrementBy;
            int count = 0;
            for (int i = 0; i < 100; i++)
            {
                incrementBy = (i % 3 == 0) ? 1 : 0;
                count += incrementBy;
            }
            Console.WriteLine(count);
        }

        public void Exercise6()
        {
            while (true)
            {
                Console.Write("Enter a number : ");
                string buffer = Console.ReadLine();
                if (buffer == "ok")
                {
                    break;
                }
                else
                {
                    Console.WriteLine(buffer);
                }
            }
        }

        public void Exercise7()
        {
            int number;
            int factorial = 1;
            Console.Write("Please enter a number : ");
            number = int.Parse(Console.ReadLine());
            while (number > 0)
            {
                factorial *= number--;
            }
            Console.WriteLine(factorial);
        }

        public void Exercise8()
        {
            Random rng = new Random();
            int guess;
            int number = rng.Next(1, 10);

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Guess a number : ");
                guess = int.Parse(Console.ReadLine());

                if (number == guess)
                {
                    Console.WriteLine("You won!");
                    break;
                }
                else if (i == 3)
                {
                    Console.WriteLine("You lost...");
                }
            }
        }

        public void Exercise9()
        {
            int currentNumber, maxNumber = 0;
            string series;
            Console.Write("Please enter a series of comma seperated numbers : ");
            series = Console.ReadLine();

            for (int i = 0; i < series.Length; i+=3)
            {
                currentNumber = (int)char.GetNumericValue(series[i]);
                if (currentNumber > maxNumber)
                    maxNumber = currentNumber;
            }

            Console.WriteLine(maxNumber);
        }
    }
}
