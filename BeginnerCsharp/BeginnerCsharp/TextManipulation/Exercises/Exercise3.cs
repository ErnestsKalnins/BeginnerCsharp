using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerCsharp.TextManipulation.Exercises
{
    class Exercise3
    {
        public static void Exercise()
        {
            Console.Write("Please enter a time in the HH:mm format: ");
            string input = Console.ReadLine();

            int[] hoursAndMinutes = ReadTimeFromString(input);

            if (AreHoursCorrect(hoursAndMinutes[0]) && AreMinutesCorrect(hoursAndMinutes[1]))
                Console.WriteLine("Ok");
            else
                Console.WriteLine("Invalid time");
        }

        private static int[] ReadTimeFromString(string timeString)
        {
            return Array.ConvertAll(timeString.Split(':'), int.Parse);
        }

        private static bool AreHoursCorrect(int hours)
        {
            return (hours >= 0 && hours < 24);
        }

        private static bool AreMinutesCorrect(int minutes)
        {
            return (minutes >= 0 && minutes < 60);
        }
    }
}
