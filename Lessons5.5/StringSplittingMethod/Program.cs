using System;
using static System.Console;

namespace StringSplittingMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string enterText;
            string[] word;
            WriteLine("Enter your text");
            enterText = ReadLine();
            WriteLine("\n\t###-Start to work-###\n");
            word = SplitText(enterText);
            PrintString(word);
            ReadLine();
        }

        static string[] SplitText(string text)
        {
            string[] word;
            char[] separators = new char[] { ' ', '.', ',', '?', '!' };
            word = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            return word;
        }

        static void PrintString(string[] word)
        {
            foreach (var item in word)
            {
                WriteLine($"{item}\n");
            }
        }
    }
}
