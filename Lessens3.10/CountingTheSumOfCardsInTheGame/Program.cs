using static System.Console;

namespace CountingTheSumOfCardsInTheGame
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool isplay = true;
            int stepCounting = 1;

            while (isplay)
            {
                bool iserror = false;
                int sumScore = 0;

                WriteLine("Hello user!\nEnter the number of cards on yours hands ");

                if (int.TryParse(ReadLine(), out int value))
                {
                    WriteLine("\t<<<Help>>>\nJack = J\nQueen = Q\nKing = K\nAce = A\nAnd your number cards\n\t<<<Help>>>\n");

                    for (int i = 0; i < value; i++)
                    {
                        WriteLine($"Enter yours cards #{i + stepCounting}");
                        string enterValue = ReadLine().ToUpper();
                        if ((int.TryParse(enterValue, out int number)))
                        {
                            sumScore += number;
                        }
                        else
                        {
                            switch (enterValue)
                            {
                                case "J":
                                case "Q":
                                case "K":
                                case "A":
                                    sumScore += 10;
                                    break;
                                default:
                                    WriteLine($"Error no invalid number card");
                                    ReadLine();
                                    iserror = true;
                                    break;
                            }
                        }
                    }
                    if (iserror)
                    {
                        WriteLine($"Error Counting\nPress Enter to Continue");
                    }
                    else
                    {
                        WriteLine($"\n\t<Sum cards on your hands {sumScore}>");
                    }
                    ReadLine();
                }
                else
                {
                    WriteLine($"Error no invalid number card");
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
