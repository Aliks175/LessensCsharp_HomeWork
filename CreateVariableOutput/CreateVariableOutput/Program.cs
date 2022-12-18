using static System.Console;

namespace CreateVariableOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Рафаэль";
            string lastName = "Амброзиус";
            string fatherName = "Кусто";
            string fullName = $"{name} {lastName} {fatherName}";
            string Email = "kysto@gmail.com";
            byte Age = 67;
            float valueScoresInProgramming = 35;
            float valueScoresInMath = 43;
            float valueScoresInPhysics = 62;
            #region NameSubjects
            string nameProgramming = "Программированию - ";
            string nameMath = "Матиматике - ";
            string namePhysics = "Физике - ";
            #endregion

            string SampleInfoOfHuman = "Полное имя :{0}\nВозраст :{2}\nEmail :{1}\n\n\tКол-во баллов по:\n";

            WriteLine(SampleInfoOfHuman, fullName, Email, Age);
            WriteLine($"{nameProgramming,22}{valueScoresInProgramming,2}");
            WriteLine($"{nameMath,22}{valueScoresInMath,2}");
            WriteLine($"{namePhysics,22}{valueScoresInPhysics,2}");
            ReadLine();
        }
    }
}
