using static System.Console;

namespace FindMinValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isplay = true;
            while (isplay)
            {
                bool iserror = false;
                int changeValue = 0;
                int minValue = 0;
                WriteLine("Hello user!\nEnter the length numbers to be checked ");

                if (int.TryParse(ReadLine(), out int value))
                {
                    for (int i = 0; i < value; i++)
                    {
                        WriteLine($"Enter your {i + 1} number");
                        if (int.TryParse(ReadLine(), out int enterValue))
                        {
                            if (i == 0)
                            {
                                changeValue = enterValue;
                                minValue = changeValue;
                            }
                            else
                            {
                                if (changeValue > enterValue)
                                {
                                    minValue = enterValue;
                                }
                            }
                        }
                        else
                        {
                            WriteLine($"Error no invalid number");
                            iserror = true;
                            ReadLine();
                            break;
                        }
                    }
                    if (iserror)
                    {
                        WriteLine($"Error Counting\nPress Enter to Continue");

                    }
                    else
                    {
                        WriteLine($"Min number array {minValue}");
                    }

                    ReadLine();
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
