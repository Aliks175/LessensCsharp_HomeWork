using System;
using static System.Console;

namespace SummMatrix
{
    internal class Program
    {
        static void FillMatrix(int[,] Matrix, Random randomValue)
        {
            for (int line = 0; line < Matrix.GetLength(0); line++)
            {
                Write($"line #{line + 1,3}.");
                for (int column = 0; column < Matrix.GetLength(1); column++)
                {
                    Matrix[line, column] = randomValue.Next(1, 10);
                    Write($"{Matrix[line, column],5}");
                }
                WriteLine();
            }
        }

        static void SummTwoMatrix(int[,] firstMatrix, int[,] secondMatrix, int[,] summMatrix)
        {
            for (int line = 0; line < summMatrix.GetLength(0); line++)
            {
                Write($"line #{line + 1,3}.");
                for (int column = 0; column < summMatrix.GetLength(1); column++)
                {
                    summMatrix[line, column] = firstMatrix[line, column] + secondMatrix[line, column];
                    Write($"{summMatrix[line, column],5}");
                }
                WriteLine();
            }
        }

        static void Main(string[] args)
        {
            bool isplay = true;
            Random random = new Random();
            while (isplay)
            {
                WriteLine("Enter the value line in Matrix");
                if (int.TryParse(ReadLine(), out int valueLine))
                {
                    WriteLine("Enter the value columns in Matrix");
                    if (int.TryParse(ReadLine(), out int valueColumns))
                    {
                        int[,] firstMatrix = new int[valueLine, valueColumns];
                        int[,] secondMatrix = new int[valueLine, valueColumns];
                        int[,] summMatrix = new int[valueLine, valueColumns];
                        WriteLine($"\n#####This is first matrix#####\n");
                        FillMatrix(firstMatrix, random);
                        WriteLine($"\n#####This is second matrix#####\n");
                        FillMatrix(secondMatrix, random);
                        WriteLine($"\nThis is matrix summ first matrix and second matrix\n");
                        SummTwoMatrix(firstMatrix, secondMatrix, summMatrix);
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
