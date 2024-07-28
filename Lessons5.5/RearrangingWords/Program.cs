using System;
using static System.Console;

namespace RearrangingWords
{
    public class Program
    {
        static void Main(string[] args)
        {
            string enterText;
            string resultString;
            WriteLine("Enter your text");
            enterText = ReadLine();
            WriteLine("\n\t###-Start to work-###\n");
            resultString = ReversWords(enterText);
            PrintWord(resultString);
            ReadLine();
        }

        static public string ReversWords(string inputPhrase)
        {
            return Reverse(inputPhrase);
        }

        static string Reverse(string text)
        {
            string[] word;
            string resultString = null;
            char[] separators = new char[] { ' ', '.', ',', '?', '!' };
            word = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            for (int i = word.Length; i > 0; i--)
            {
                if (word[i - 1] != null)
                {
                    resultString += word[i - 1] + ' ';
                }
            }
            return resultString;
        }

        static void PrintWord(string word)
        {
            WriteLine(word + ' ');
        }
    }
}
