using System;
using static System.Console;

namespace RandomMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isplay = true;

            Random random = new Random();

            while (isplay)
            {
                int summ = 0;
                WriteLine("Enter the value line in Matrix, no more 100 line");

                if ((int.TryParse(ReadLine(), out int valueLine) && valueLine < 101))
                {
                    WriteLine("Enter the value columns in Matrix, no more 6 columns");
                    if ((int.TryParse(ReadLine(), out int valueColumns) && valueColumns < 7))
                    {
                        int[,] enterMatrix = new int[valueLine, valueColumns];

                        for (int line = 0; line < enterMatrix.GetLength(0); line++)
                        {
                            if (line == 0)
                            {
                                for (int i = 0; i < enterMatrix.GetLength(1); i++)
                                {
                                    string infocolumn = "column #";
                                    Write($"{infocolumn,16} {i + 1}");
                                }
                                WriteLine();
                            }

                            Write($"line #{line + 1,3}");

                            for (int column = 0; column < enterMatrix.GetLength(1); column++)
                            {
                                enterMatrix[line, column] = random.Next(1, 10);
                                summ += enterMatrix[line, column];


                                if (column == 0)
                                {
                                    Write($"{enterMatrix[line, column],5}");
                                }
                                else
                                {
                                    Write($"{enterMatrix[line, column],18}");
                                }
                            }
                            WriteLine();
                        }
                        Write($"\nSumm of all the numbers in Matrix = {summ}");
                    }
                    else
                    {
                        WriteLine($"Error no invalid number");
                        ReadLine();
                        break;
                    }
                }
                else
                {
                    WriteLine($"Error no invalid number");
                    ReadLine();
                    break;
                }
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
    }
}
