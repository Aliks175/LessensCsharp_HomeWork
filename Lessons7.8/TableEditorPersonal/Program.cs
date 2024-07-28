using System;
using System.IO;
using static System.Console;

namespace TableEditorPersonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Worker[] worker;
            string enterText;
            string pathFile = @"PersonalAffairsForEmployees.txt";

                //if (F.Exists)
                //{
                //    WriteLine("File loaded");
                //}
                //else
                //{
                //    File.Create(pathFile);
                //    WriteLine("File Create");
                //}
            

            Repository repository = new Repository(pathFile);
            //
            WriteLine("Select from the list");
            WriteLine("1 - View all records\n2 - Find by id\n3 - Creating a record\n4 - Dell a record\n5 - Date search ");
            
            enterText = ReadLine();

            if (enterText == 1.ToString())
            {
                worker = repository.GetAllWorkers();
                repository.PrintToScreen(worker);
                ReadLine();
            }
            else if (enterText == 2.ToString())
            {
               string id = ReadLine();
                if (int.TryParse(id,out int reult))
                {
                    worker = repository.GetAllWorkers();
                    repository.PrintToScreen(reult);
                }
                else
                {
                    WriteLine("Error enter Id ");
                    //continou
                }
            }
            else if (enterText == 3.ToString())
            {
                repository.WriteWorker();

            }
            else if (enterText == 4.ToString())
            {
                string id = ReadLine();
                if (int.TryParse(id, out int reult))
                {
                    repository.DeleteWorker(reult);
                }
                else
                {
                    WriteLine("Error enter Id ");
                    //continou
                }
                
            }
            else if (enterText == 5.ToString())
            {
                
                //DateTime  dateFrom;
                //DateTime dateTo;
                ////
                //WriteLine("Enter Date 01.01.2023 ");
                //WriteLine("Enter Date From");

                //if (DateTime.TryParse(ReadLine(),out DateTime enterDateFrom))
                //{
                //     dateFrom = enterDateFrom;
                //}
                //else
                //{
                //    WriteLine("Error enter DateTime ");
                //}

                //WriteLine("Enter Date 01.01.2023 ");
                //WriteLine("Enter Date To");

                //if (DateTime.TryParse(ReadLine(), out DateTime enterDateTo))
                //{
                //     dateTo = enterDateTo;
                //}
                //else
                //{
                //    WriteLine("Error enter DateTime ");
                //}
                /////
                //repository.PrintToScreen(repository.GetWorkersBetweenTwoDates(dateFrom, dateTo));
            }
            else
            {
                WriteLine("Error, Select from the list");
            }
            //



            //        bool isPlayBack = true;
            //        while (isPlayBack)
            //        {
            //            WriteLine("\tChoose a further action\n" + "1.Data output\n" + "2.Data entry\n");
            //            if (int.TryParse(ReadLine(), out int enterNumber) && enterNumber > 0 && enterNumber < 3)
            //            {
            //            }
            //            else
            //            {
            //                WriteLine("Error, invalid value entered");
            //                ReadLine();
            //                continue;
            //            }
            //            FileStream t = new FileStream(pathFile, FileMode.OpenOrCreate);
            //            t.Close();
            //            if (enterNumber == 1)
            //            {
            //                using (StreamReader f = new StreamReader(pathFile))
            //                {
            //                    Clear();
            //                    while (!f.EndOfStream)
            //                    {
            //                        foreach (var item in f.ReadLine().Split('#'))
            //                        {
            //                            Write(item + ' ');
            //                        }
            //                        WriteLine();
            //                    }
            //                }
            //            }
            //            else
            //            {
            //                string[] str = File.ReadAllLines(pathFile);
            //                if (str.Length == 0)
            //                {
            //                    str = new string[1];
            //                }
            //                using (StreamWriter f = new StreamWriter(pathFile))
            //                {
            //                    Directory directory = AddEmployee(pathFile);
            //                    if (directory.fullName == null)
            //                    {
            //                        WriteLine("Error, failed to add an employee check the correctness of the data and re-enter");
            //                    }
            //                    else
            //                    {
            //                        str[str.Length - 1] = SaveEmployee(directory, str.Length);
            //                        foreach (var item in str)
            //                        {
            //                            f.WriteLine(item);
            //                        }
            //                    }
            //                }
            //            }

            //            WriteLine("Continue: Y or N");
            //            string userSelection = ReadLine().ToUpper();
            //            switch (userSelection)
            //            {
            //                case "Y":
            //                    break;
            //                case "N":
            //                    isPlayBack = false;
            //                    break;
            //                default:
            //                    WriteLine("Error\nPress Enter to Continue");
            //                    ReadLine();
            //                    Clear();
            //                    break;
            //            }
            //        }
            //    }

            //    static Directory AddEmployee(string pathFile)
            //    {
            //        Directory directory = new Directory();
            //        WriteLine("Enter fullName Employee (Sample: Иванов Иван Иванович)");
            //        directory.fullName = ReadLine();
            //        bool iserror;
            //        iserror = false;
            //        directory.time = File.GetLastWriteTime(pathFile);
            //        WriteLine("Enter age Employee(Sample: 28)");
            //        if (int.TryParse(ReadLine(), out directory.age))
            //        {
            //        }
            //        else
            //        {
            //            WriteLine("Error enter age");
            //            iserror = true;
            //        }
            //        WriteLine("Enter stature Employee(Sample: 178)");
            //        if (float.TryParse(ReadLine(), out directory.stature))
            //        {
            //        }
            //        else
            //        {
            //            WriteLine("Error enter stature");
            //            iserror = true;
            //        }
            //        WriteLine("Enter dateOfBirth Employee(Sample: 05.05.1992)");
            //        if (DateTime.TryParse(ReadLine(), out directory.dateOfBirth))
            //        {
            //            WriteLine("Enter placeOfBirth Employee(Sample: to Moscow)");
            //            directory.placeOfBirth = ReadLine();
            //        }
            //        else
            //        {
            //            WriteLine("Error enter dateOfBirth");
            //            iserror = true;
            //        }
            //        if (iserror)
            //        {
            //            directory.fullName = null;
            //            directory.age = 0;
            //            directory.stature = 0;
            //            directory.dateOfBirth = DateTime.MinValue;
            //            directory.placeOfBirth = null;
            //        }
            //        return directory;
            //    }

            //    static string SaveEmployee(Directory directory, int id)
            //    {
            //        string s;
            //        s = string.Join("#", id, directory.time, directory.fullName, directory.age, directory.stature, directory.dateOfBirth.ToShortDateString(), directory.placeOfBirth + '\n');
            //        return s;
        }
    }
}
