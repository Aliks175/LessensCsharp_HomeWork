using static System.Console;

namespace IntegerOrOddNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isplay = true;

            while (isplay)
            {
                WriteLine("Enter the Number");

                if (int.TryParse(ReadLine(), out int value))
                {
                    if (value % 2 == 0)
                    {
                        WriteLine($"{value} <> Integer Number");
                    }
                    else
                    {
                        WriteLine($"{value} <> Odd Number");
                    }
                }
                else
                {
                    WriteLine($"Error no invalid number");
                    ReadLine();
                }

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
    }
}
