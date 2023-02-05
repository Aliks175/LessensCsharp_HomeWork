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
            string pathFile = @"D:\Test.txt";
            string[] stringsText;
            bool isPlayBack = true;
            while (isPlayBack)
            {
                WriteLine("\tВыберите дальнейшее действие\n" + "1.Вывод данных\n" + "2.Ввод данных\n");
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
                                WriteLine("Ошибка, неудалось добавить сотрудника проверьте корректность данных и повторите ввод");
                            }
                            else
                            {
                                str[str.Length - 1] = SaveEmployee(directory, numberString);
                            }
                            File.WriteAllLines(pathFile, str);

                        }
                        stringsText = File.ReadAllLines(pathFile);  //метод на отображение данных
                    }
                    else
                    {
                        using (File.Create(pathFile))
                            WriteLine("Создать файл");
                    }
                }
                else
                {
                    WriteLine("Ошибка, введенно неверное значение");
                }
                WriteLine("Продолжить");
                ReadLine();
            }
        }

        static Directory AddEmployee(string pathFile)
        {
            Directory directory = new Directory();
            WriteLine("FullName(Sample:fullName Иванов Иван Иванович)");
            directory.fullName = ReadLine();
            bool iserror;
            iserror = false;
            directory.time = File.GetLastWriteTime(pathFile);
            WriteLine("Age(Sample:Age 28)");
            if (int.TryParse(ReadLine(), out directory.age))
            {
                WriteLine("Stature(Sample:Stature 178)");
                if (float.TryParse(ReadLine(), out directory.stature))
                {
                    WriteLine("DateOfBirth(Sample:DateOfBirth 05.05.1992)");
                    if (DateTime.TryParse(ReadLine(), out directory.dateOfBirth))
                    {

                        WriteLine("PlaceOfBirth(Sample:PlaceOfBirth to Moscow)");
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
            //1#20.12.2021 00:12#Иванов Иван Иванович#25#176#05.05.1992#город Москва
            string s;
            s = $"{id}#{directory.time}#{directory.fullName}#{directory.age}#{directory.stature}#{directory.dateOfBirth.ToShortDateString()}#{directory.placeOfBirth}\n ";
            return s;
        }
    }
}
