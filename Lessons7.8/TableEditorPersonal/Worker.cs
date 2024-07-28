using System;

namespace TableEditorPersonal
{
    internal struct Worker
    {
        public Worker(int Id, DateTime TimeCreate, string FullName, int Age, float Stature, DateTime DateOfBirth, string PlaceOfBirth)
        {
            this.id = Id;
            this.timeCreate = TimeCreate;
            this.fullName = FullName;
            this.age = Age;
            this.stature = Stature;
            this.dateOfBirth = DateOfBirth;
            this.placeOfBirth = PlaceOfBirth;

        }

        

        private int id;
        private DateTime timeCreate;
        private string fullName;
        private int age;
        private float stature;
        private DateTime dateOfBirth;
        private string placeOfBirth;


        //public string FirstName { get { return this.firstName; } set { this.firstName = value; } }
        public int Id { get { return id; } set { id = value; } }
        public DateTime TimeCreate { get { return timeCreate; } set { timeCreate = value; } }
        public string FullName { get { return fullName; } set { fullName = value; } }
        public int Age { get { return id; } set { id = value; } }
        public float Stature { get { return stature; } set { stature = value; } }
        public DateTime DateOfBirth { get { return dateOfBirth; } set { dateOfBirth = value; } }
        public string PlaceOfBirth { get { return placeOfBirth; } set { placeOfBirth = value; } }

        public string Print()
        {
            string str;
            return str =$"{id}#{timeCreate}#{fullName}#{age}#{stature}#{dateOfBirth}#{placeOfBirth}";
        }

        public void Dell()
        {
            id = -1;
            timeCreate = DateTime.MinValue;
            fullName = null;
            age = 0;
            stature = 0;
            dateOfBirth= DateTime.MinValue;
            placeOfBirth = null;
        }
    }
}
