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
            string pathFile = @"PersonalAffairsForEmployees.txt";
            bool isPlayBack = true;
            while (isPlayBack)
            {
                WriteLine("\tChoose a further action\n" + "1.Data output\n" + "2.Data entry\n");
                if (int.TryParse(ReadLine(), out int enterNumber) && enterNumber > 0 && enterNumber < 3)
                {
                }
                else
                {
                    WriteLine("Error, invalid value entered");
                    ReadLine();
                    continue;
                }
                FileStream t = new FileStream(pathFile, FileMode.OpenOrCreate);
                t.Close();
                if (enterNumber == 1)
                {
                    using (StreamReader f = new StreamReader(pathFile))
                    {
                        Clear();
                        while (!f.EndOfStream)
                        {
                            foreach (var item in f.ReadLine().Split('#'))
                            {
                                Write(item + ' ');
                            }
                            WriteLine();
                        }
                    }
                }
                else
                {
                    string[] str = File.ReadAllLines(pathFile);
                    if (str.Length == 0)
                    {
                        str = new string[1];
                    }
                    using (StreamWriter f = new StreamWriter(pathFile))
                    {
                        Directory directory = AddEmployee(pathFile);
                        if (directory.fullName == null)
                        {
                            WriteLine("Error, failed to add an employee check the correctness of the data and re-enter");
                        }
                        else
                        {
                            str[str.Length - 1] = SaveEmployee(directory, str.Length);
                            foreach (var item in str)
                            {
                                f.WriteLine(item);
                            }
                        }
                    }
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
            }
            else
            {
                WriteLine("Error enter age");
                iserror = true;
            }
            WriteLine("Enter stature Employee(Sample: 178)");
            if (float.TryParse(ReadLine(), out directory.stature))
            {
            }
            else
            {
                WriteLine("Error enter stature");
                iserror = true;
            }
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
            s = string.Join("#", id, directory.time, directory.fullName, directory.age, directory.stature, directory.dateOfBirth.ToShortDateString(), directory.placeOfBirth + '\n');
            return s;
        }
    }
}
