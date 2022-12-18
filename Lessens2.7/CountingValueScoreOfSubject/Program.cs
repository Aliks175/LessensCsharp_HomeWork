using System;
using static System.Console;

namespace CountingValueScoreOfSubject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float valueScoresInProgramming = 35;
            float valueScoresInMath = 43;
            float valueScoresInPhysics = 62.1f;
            float summScore;
            float averageOfValue;
            int valueSubject = 3;

            summScore = valueScoresInProgramming + valueScoresInMath + valueScoresInPhysics;
            averageOfValue = summScore / valueSubject;

            WriteLine("Общий Балл : " + summScore.ToString("#"));
            //Console.WriteLine("Средний Балл : " + averageOfValue.ToString("#.#"));
            WriteLine("Средний Балл : " + Math.Round(averageOfValue, 1));
            ReadLine();
        }
    }
}
