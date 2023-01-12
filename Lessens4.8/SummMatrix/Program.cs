using System;
using static System.Console;

namespace SummMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isplay = true;


            Random random = new Random();

            while (isplay)
            {
                WriteLine("Enter the value line in Matrix, no more 100 line");

                if ((int.TryParse(ReadLine(), out int valueLine) && valueLine < 101))
                {
                    WriteLine("Enter the value columns in Matrix, no more 6 columns");
                    if ((int.TryParse(ReadLine(), out int valueColumns) && valueColumns < 7))
                    {
                        int[,] firstMatrix = new int[valueLine, valueColumns];
                        int[,] secondMatrix = new int[valueLine, valueColumns];
                        int[,] summMatrix = new int[valueLine, valueColumns];

                        for (int reprintMatrix = 1; reprintMatrix < 4; reprintMatrix++)
                        {
                            if (reprintMatrix == 3)
                            {
                                WriteLine($"\nThis is matrix summ first matrix and second matrix\n");
                            }
                            else
                            {
                                WriteLine($"\nThis is Matrix # {reprintMatrix}\n");
                            }
                            for (int line = 0; line < firstMatrix.GetLength(0); line++)
                            {
                                if (line == 0)
                                {
                                    for (int numberColumn = 0; numberColumn < firstMatrix.GetLength(1); numberColumn++)
                                    {
                                        string infocolumn = "column #";
                                        Write($"{infocolumn,16} {numberColumn + 1}");
                                    }
                                    WriteLine();
                                }

                                Write($"line #{line + 1,3}");

                                for (int column = 0; column < firstMatrix.GetLength(1); column++)
                                {
                                    if (reprintMatrix == 3)
                                    {
                                        firstMatrix[line, column] = secondMatrix[line, column] + firstMatrix[line, column];
                                    }
                                    else
                                    {
                                        firstMatrix[line, column] = random.Next(1, 10);
                                        if (reprintMatrix == 1)
                                        {
                                            secondMatrix[line, column] = firstMatrix[line, column];
                                        }
                                    }

                                    if (column == 0)
                                    {
                                        Write($"{firstMatrix[line, column],5}");
                                    }
                                    else
                                    {
                                        Write($"{firstMatrix[line, column],18}");
                                    }
                                }
                                WriteLine();
                            }
                        }
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
