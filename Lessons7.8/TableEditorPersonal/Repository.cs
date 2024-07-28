using System;
using System.IO;
using static System.Console;

namespace TableEditorPersonal
{
    internal class Repository
    {
        private Worker[] workers;

        private string path;
        private string[] fields;

        int index;

        public Repository(string Path)
        {
            this.path = Path;
            this.index = 0;
            this.workers = new Worker[3];
            fields = new string[7];
        }

        private void Resize(bool Flag,Array array)
        {
            if (Flag)
            {
                Array.Resize(ref workers, workers.Length * 2);
            }
        }

        public Worker[] GetAllWorkers()
        {
            // здесь происходит чтение из файла
            // и возврат массива считанных экземпляров
            using (StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] args = sr.ReadLine().Split('#');

                    SaveWorkerToArray(ReadWorker(args));
                    //метод который будет требовать Worker а возвращать массив воркер
                    //метод сохранение строки в формате воркера 
                }
            }
            return workers;
        }

        public void PrintToScreen(Worker[] arrayWorker)
        {
            foreach (var item in arrayWorker)
            {
                WriteLine(item.Print());
            }
        }
        public void PrintToScreen(int id)
        {
            if (GetWorkerById(id).Id < 0)
            {
                WriteLine("Error, Id not found ");
            }

        }

        private void SaveWorkerToArray(Worker worker)
        {
            Resize(index >= workers.Length,workers);
            workers[index] = worker;
            index++;
        }


        private Worker ReadWorker(string[] args)
        {
            return new Worker
            {
                Id = Convert.ToInt32(args[0]),
                TimeCreate = Convert.ToDateTime(args[1]),
                FullName = args[2],
                Age = Convert.ToInt32(args[3]),
                Stature = Convert.ToInt32(args[4]),
                DateOfBirth = Convert.ToDateTime(args[5]),
                PlaceOfBirth = args[6],
            };
        }



        public Worker GetWorkerById(int id)
        {
            Worker foundWorker = Array.Find(workers, (worker) => worker.Id == id);
            //Проверку на пустоту
            if (foundWorker.Id != 0)
            {
                WriteLine(foundWorker.Print());
            }
            else
            {
                foundWorker.Dell();
            }
            return foundWorker;

            // происходит чтение из файла, возвращается Worker
            // с запрашиваемым ID

        }

        public void DeleteWorker(int id)
        {
            GetAllWorkers();
            foreach (Worker worker in workers)
            {
                if (worker.Id == id)
                {
                    worker.Dell();
                }
            }
            SaveToFile();
        }

        //public void DeleteWorker(int id)
        //{
        //    for (int i = 0; i < index; i++)
        //    {
        //        if (workers[i].Id== id)
        //        {
        //            Array.Clear(workers, i, 0);
        //        }

        //    }
        //    Array.Sort(workers);
        //    SaveToFile();
        //    // считывается файл, находится нужный Worker
        //    // происходит запись в файл всех Worker,
        //    // кроме удаляемого
        //}



        public void WriteWorker()
        {
            while (true)
            {
                try
                {
                    fields[0] = index.ToString();
                    fields[1] = DateTime.Now.ToString();
                    WriteLine("Enter fullName Employee (Sample: Иванов Иван Иванович)");
                    fields[2] = ReadLine();
                    WriteLine("Enter age Employee(Sample: 28)");
                    fields[3] = ReadLine();
                    WriteLine("Enter stature Employee(Sample: 178)");
                    fields[4] = ReadLine();
                    WriteLine("Enter dateOfBirth Employee(Sample: 05.05.1992)");
                    fields[5] = ReadLine();
                    WriteLine("Enter placeOfBirth Employee(Sample: to Moscow)");
                    fields[6] = ReadLine();
                }
                catch ()
                {
                    WriteLine("\n\t Input error, please repeat");
                    continue;
                }
                AddWorker(ReadWorker(fields));
                break;
            }
        }

        public void AddWorker(Worker worker)
        {
            SaveWorkerToArray(worker);
            SaveToFile();

            //string[] str = .ToString();
            //ReadWorker(str);
            // присваиваем worker уникальный ID,
            // дописываем нового worker в файл
        }

        private void SaveToFile()
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                for (int i = 0; i < index; i++)
                {
                    if (workers[i].Id != -1)
                    {
                        sw.WriteLine(workers[i].Print());
                    }

                }
            }
        }

        

        public Worker[] GetWorkersBetweenTwoDates(DateTime dateFrom, DateTime dateTo)
        {
            Worker[] work = new Worker[workers.Length];
            int i = 0;
            GetAllWorkers();
            foreach (var worker in workers)
            {
                if (worker.DateOfBirth>=dateFrom&& worker.DateOfBirth <= dateTo)
                {
                    work[i]= worker;
                    i++;
                }
            }
            Array.Sort(work);
            return work;
            // здесь происходит чтение из файла
            // фильтрация нужных записей
            // и возврат массива считанных экземпляров
        }
    }
}


