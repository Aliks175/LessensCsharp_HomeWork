using static System.Console;

namespace RearrangingWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isplay = true;
            while (isplay)
            {
                string enterText;
                int valueBlankSpace = 0;
                WriteLine("Enter your text");
                enterText = ReadLine();
                WriteLine("\n\t###-Start to work-###\n");
                foreach (var item in enterText)
                {
                    if (item == ' ')
                    {
                        valueBlankSpace++;
                    }
                }
                PrintWord(SearchWord(enterText, valueBlankSpace + 1));
                ReadLine();
                WriteLine("Exit to Program ?\nY or N");
                string userSelection = ReadLine().ToUpper();
                switch (userSelection)
                {
                    case "Y":
                        isplay = false;
                        break;
                    case "N":
                        break;
                    default:
                        WriteLine("Error\nPress Enter to Continue");
                        ReadLine();
                        break;
                }
                Clear();
            }
        }

        static string[] SearchWord(string text, int valueWord)
        {
            string[] word;
            int valueSaveWords = 0;
            int firstIndexLetterWord = 0;
            int endIndexLetterWord = 0;
            word = new string[valueWord];
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    endIndexLetterWord = i;
                    word[valueSaveWords] = SaveWord(text, firstIndexLetterWord, endIndexLetterWord);
                    valueSaveWords++;
                    firstIndexLetterWord = endIndexLetterWord + 1;
                }
            }
            if (endIndexLetterWord < text.Length)
            {
                endIndexLetterWord = text.Length;
                word[valueSaveWords] = SaveWord(text, firstIndexLetterWord, endIndexLetterWord);
            }
            return word;
        }

        static string SaveWord(string text, int firstIndex, int endIndex)
        {
            string word = null;
            for (int i = firstIndex; i < endIndex; i++)
            {
                if (text[i] == ' ')
                {
                    continue;
                }
                else
                {
                    word += text[i];
                }
            }
            return word;
        }

        static void PrintWord(string[] word)
        {
            for (int i = word.Length - 1; i > -1; i--)
            {
                Write($"{word[i]} ");
            }
        }
    }
}
