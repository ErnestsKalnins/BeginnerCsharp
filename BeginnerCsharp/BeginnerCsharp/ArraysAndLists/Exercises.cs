using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerCsharp.ArraysAndLists
{
    class Exercises
    {
        public void Exercise1()
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

                    switch (people.Count)
                    {
                        case 1:
                            Console.WriteLine(
                                "{0} likes your post", 
                                people[0]
                            );
                            break;

                        case 2:
                            Console.WriteLine(
                                "{0} and {1} likes your post", 
                                people[0], 
                                people[1]
                            );
                            break;

                        default:
                            Console.WriteLine(
                                "{0}, {1} and {2} others like your post",
                                people[0],
                                people[1],
                                people.Count - 2
                            );
                            break;
                    }
                }
            }
        }

        public void Exercise2()
        {
            string name;
            Console.Write("Please enter your name: ");
            name = Console.ReadLine();

            char[] buffer = name.ToCharArray();
            Array.Reverse(buffer);
            string reversedName = new string(buffer);
            Console.WriteLine(reversedName);
        }

        public void Exercise3()
        {
            List<int> numbers = new List<int>();
            int currentNumber;
            while (numbers.Count < 5)
            {
                Console.Write("Please enter a number: ");
                currentNumber = int.Parse(Console.ReadLine());

                if (numbers.IndexOf(currentNumber) >= 0)
                {
                    Console.WriteLine("Number already exists in the list, try again!");
                }
                else
                {
                    numbers.Add(currentNumber);
                }
            }

            numbers.Sort();
            Console.WriteLine(string.Join(" ", numbers));
        }

        public void Exercise4()
        {
            List<int> numbers = new List<int>();
            int currentNumber;
            string buffer;
            while (true)
            {
                Console.Write("Please enter a number: ");

                buffer = Console.ReadLine();

                if (buffer == "Quit")
                    break;

                currentNumber = int.Parse(buffer);
                numbers.Add(currentNumber);

                List<int> uniqueNumbers = new List<int>();
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (uniqueNumbers.IndexOf(numbers[i]) >= 0)
                    {
                        continue;
                    }
                    else
                    {
                        uniqueNumbers.Add(numbers[i]);
                    }
                }
                Console.WriteLine(string.Join(", ", uniqueNumbers));
            }
        }

        public void Exercise5()
        {
            Console.WriteLine("Please enter a list of at least 5 comma seperated numbers: ");
            string numberString = Console.ReadLine();

            int[] numbers = Array.ConvertAll(numberString.Split(','), int.Parse);
            List<int> numberList = numbers.ToList();

            if (numberList.Count < 5)
            {
                Console.WriteLine("Invalid list!");
            }
            else
            {
                numberList.Sort();
                Console.WriteLine("{0}, {1}, {2}", numberList[0], numberList[1], numberList[2]);
            }
        }
    }
}
