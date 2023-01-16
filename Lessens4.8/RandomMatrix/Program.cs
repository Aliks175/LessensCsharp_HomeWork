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
                WriteLine("Enter the value line in Matrix");
                if (int.TryParse(ReadLine(), out int valueLine))
                {
                    WriteLine("Enter the value columns in Matrix");
                    if (int.TryParse(ReadLine(), out int valueColumns))
                    {
                        int[,] enterMatrix = new int[valueLine, valueColumns];
                        for (int line = 0; line < enterMatrix.GetLength(0); line++)
                        {
                            Write($"line #{line + 1,3}.");
                            for (int column = 0; column < enterMatrix.GetLength(1); column++)
                            {
                                enterMatrix[line, column] = random.Next(1, 10);
                                summ += enterMatrix[line, column];
                                Write($"{enterMatrix[line, column],5}");
                            }
                            WriteLine();
                        }
                        Write($"\nSumm of all the numbers in Matrix = {summ}");
                    }
                    else
                    {
                        WriteLine($"Error no invalid value columns in Matrix");
                        ReadLine();
                        break;
                    }
                }
                else
                {
                    WriteLine($"Error no invalid value line in Matrix");
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
