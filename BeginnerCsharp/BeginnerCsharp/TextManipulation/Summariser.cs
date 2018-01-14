using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerCsharp.TextManipulation
{
    public class Summariser
    {
        public static string Summary(string text, int maxLength = 20)
        {
            if (text.Length < maxLength)
                return text;

            string[] words = text.Split(' ');

            var totalCharacters = 0;
            List<string> summaryWords = new List<string>();

            foreach (string word in words)
            {
                summaryWords.Add(word);
                totalCharacters += word.Length + 1;
           
                if (totalCharacters > maxLength)
                {
                    break;
                }
            }
            string summary = string.Join(" ", summaryWords) + "...";
            return summary;
        }
    }
}
