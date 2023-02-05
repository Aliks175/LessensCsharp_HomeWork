using System;
using System.IO;
using static System.Console;

namespace CreatePersonalBusiness
{
    internal struct Directory
    {
        public DateTime time;
        public string fullName;
        public int age;
        public float stature;
        public DateTime dateOfBirth;
        public string placeOfBirth;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int enterNumber;
            string pathFile = @"PersonalAffairsForEmployees.txt";
            string[] stringsText;
            bool isPlayBack = true;
            while (isPlayBack)
            {
                WriteLine("\tChoose a further action\n" + "1.Data output\n" + "2.Data entry\n");
                if (int.TryParse(ReadLine(), out enterNumber) && enterNumber > 0 && enterNumber < 3)
                {
                    if (File.Exists(pathFile))
                    {
                        stringsText = File.ReadAllLines(pathFile);
                        if (enterNumber == 1)
                        {
                            Clear();
                            for (int i = 0; i < stringsText.GetLength(0); i++)
                            {
                                WriteLine(stringsText[i]);
                            }
                        }
                        else
                        {
                            int numberString = 1;
                            string[] str = new string[stringsText.Length + 1];
                            for (int i = 0; i < stringsText.Length; i++)
                            {
                                if (stringsText[i] != " ")
                                {
                                    numberString++;
                                }
                                str[i] = stringsText[i];
                            }
                            Directory directory = AddEmployee(pathFile);
                            if (directory.fullName == null)
                            {
                                WriteLine("Error, failed to add an employee check the correctness of the data and re-enter");
                            }
                            else
                            {
                                str[str.Length - 1] = SaveEmployee(directory, numberString);
                            }
                            File.WriteAllLines(pathFile, str);

                        }
                        stringsText = File.ReadAllLines(pathFile);
                    }
                    else
                    {
                        using (File.Create(pathFile))
                            WriteLine("File created");
                        continue;
                    }
                }
                else
                {
                    WriteLine("Error, invalid value entered");
                }
                WriteLine("Continue: Y or N");

                string userSelection = ReadLine().ToUpper();

                switch (userSelection)
                {
                    case "Y":
                        break;
                    case "N":
                        isPlayBack = false;
                        break;
                    default:
                        WriteLine("Error\nPress Enter to Continue");
                        ReadLine();
                        Clear();
                        break;
                }
            }
        }

        static Directory AddEmployee(string pathFile)
        {
            Directory directory = new Directory();
            WriteLine("Enter fullName Employee (Sample: Иванов Иван Иванович)");
            directory.fullName = ReadLine();
            bool iserror;
            iserror = false;
            directory.time = File.GetLastWriteTime(pathFile);
            WriteLine("Enter age Employee(Sample: 28)");
            if (int.TryParse(ReadLine(), out directory.age))
            {
                WriteLine("Enter stature Employee(Sample: 178)");
                if (float.TryParse(ReadLine(), out directory.stature))
                {
                    WriteLine("Enter dateOfBirth Employee(Sample: 05.05.1992)");
                    if (DateTime.TryParse(ReadLine(), out directory.dateOfBirth))
                    {
                        WriteLine("Enter placeOfBirth Employee(Sample: to Moscow)");
                        directory.placeOfBirth = ReadLine();
                    }
                    else
                    {
                        WriteLine("Error enter dateOfBirth");
                        iserror = true;
                    }
                }
                else
                {
                    WriteLine("Error enter stature");
                    iserror = true;
                }
            }
            else
            {
                WriteLine("Error enter age");
                iserror = true;
            }
            if (iserror)
            {
                directory.fullName = null;
                directory.age = 0;
                directory.stature = 0;
                directory.dateOfBirth = DateTime.MinValue;
                directory.placeOfBirth = null;
            }
            return directory;
        }

        static string SaveEmployee(Directory directory, int id)
        {
            string s;
            s = $"{id} {directory.time} {directory.fullName} {directory.age} {directory.stature} {directory.dateOfBirth.ToShortDateString()} {directory.placeOfBirth}\n ";
            return s;
        }
    }
}
