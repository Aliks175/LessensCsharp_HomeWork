using static System.Console;

namespace CountingTheSumOfCardsInTheGame
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool isplay = true;

            while (isplay)
            {
                bool iserror = false;
                int sumScore = 0;

                WriteLine("Hello user!\nEnter the number of cards on yours hands ");

                if (int.TryParse(ReadLine(), out int enterCard))
                {
                    if (enterCard > 0)
                    {
                        WriteLine("\t<<<Help>>>\nJack = J\nQueen = Q\nKing = K\nAce = A\nAnd your number cards\n\t<<<Help>>>\n");
                        for (int i = 0; i < enterCard; i++)
                        {
                            WriteLine($"Enter yours cards #{i + 1}");
                            string enterValue = ReadLine().ToUpper();
                            if ((int.TryParse(enterValue, out int enterNumberCard)))
                            {
                                if (enterNumberCard > 0 && enterNumberCard < 11)
                                {
                                    sumScore += enterNumberCard;
                                }
                                else
                                {
                                    WriteLine($"Error no invalid number card");
                                    iserror = true;
                                    break;
                                }

                            }
                            else
                            {
                                if (enterValue == "J" || enterValue == "Q" || enterValue == "K" || enterValue == "A")
                                {
                                    sumScore += 10;
                                }
                                else
                                {
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
