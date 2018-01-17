using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerCsharp.ArraysAndLists.Exercises
{
    class Exercise1
    {
        public static void Exercise()
        {
            List<string> people = new List<string>();
            string newPerson;

            while (true)
            {
                Console.Write("Enter a persons name: ");
                newPerson = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(newPerson))
                {
                    break;
                }
                else
                {
                    people.Add(newPerson);
                }

                ResolveMessage(people);
            }
        }

        private static void ResolveMessage(List<string> peopleList)
        {
            if (peopleList.Count < 1)
                throw new ArgumentOutOfRangeException(
                    "Count", 
                    "People list count must contain at least one string."
                    );

            switch (peopleList.Count)
            {
                case 1:
                    DisplayOnePeopleLikedMessage(peopleList);
                    break;

                case 2:
                    DisplayTwoPeopleLikedMessage(peopleList);
                    break;

                default:
                    DisplayMultiplePeopleLikedMessage(peopleList);
                    break;
            }
        }

        private static void DisplayOnePeopleLikedMessage(List<string> peopleList)
        {
            Console.WriteLine(
                "{0} likes your post",
                peopleList[0]
            );
        }

        private static void DisplayTwoPeopleLikedMessage(List<string> peopleList)
        {
            Console.WriteLine(
                "{0} and {1} likes your post",
                peopleList[0],
                peopleList[1]
            );
        }

        private static void DisplayMultiplePeopleLikedMessage(List<string> peopleList)
        {
            Console.WriteLine(
                "{0}, {1} and {2} others like your post",
                peopleList[0],
                peopleList[1],
                peopleList.Count - 2
            );
        }
    }
}
