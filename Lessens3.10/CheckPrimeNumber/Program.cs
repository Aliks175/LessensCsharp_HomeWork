using static System.Console;
namespace CheckPrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool isplay = true;

            while (isplay)
            {
                bool isprimeNumber = true;

                WriteLine("Hello user!\nEnter the number ");

                if (int.TryParse(ReadLine(), out int value))
                {
                    int i = 2;
                    while (i < value - 1)
                    {
                        if (value % i == 0)
                        {
                            isprimeNumber = false;
                            break;
                        }
                        i++;
                    }

                    if (isprimeNumber)
                    {
                        WriteLine($"Number Prime");
                    }
                    else
                    {
                        WriteLine($"Number No Prime");
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
