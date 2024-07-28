using System;
using static System.Console;

namespace StringSplittingMethod
{
    public class Program
    {
        static void Main(string[] args)
        {
            Split split = new Split();
            string enterText;
            string[] word;
            WriteLine("Enter your text");
            enterText = ReadLine();
            WriteLine("\n\t###-Start to work-###\n");
            word = split.SplitText(enterText);
            split.PrintString(word);
            ReadLine();
        }
    }

    public class Split
    {
        public string[] SplitText(string text)
        {
            string[] word;
            char[] separators = new char[] { ' ', '.', ',', '?', '!' };
            word = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            return word;
        }

        public void PrintString(string[] word)
        {
            foreach (var item in word)
            {
                WriteLine($"{item}\n");
            }
        }
    }
}
