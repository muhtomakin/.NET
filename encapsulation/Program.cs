using System;

namespace encapsulation {
    class Program {
        static void Main(string[] args) {
            Student student = new Student();
            student.Name = "Toma";
            student.Surname = "Müller";
            student.No = 1023;
            student.Category = 3;
            student.GetStudentInformations();

            student.IncreaseCategory();
            student.GetStudentInformations();

            Student student2 = new Student("Christoph", "Toma", 4127, 1);
            student2.DecreaseCategory();
            student2.DecreaseCategory();
            student2.GetStudentInformations();
        }
    }
    class Student {
        private string name;
        private string surname;
        private int no;
        private int category;
        public string Name {
            get { return name; }
            set { name = value; }
        }
        public string Surname { get => surname; set => surname = value; }
        public int No { get => no; set => no = value; }
        public int Category { 
            get => category; 
            set { 
                if ( value < 1 ) {
                    Console.WriteLine("Category must be at least 1!");
                    category = 1;
                } else {
                    category = value;
                } 
            } 
        }
        public Student(string name, string surname, int no, int category) {
            Name = name;
            Surname = surname;
            No = no;
            Category = category;
        }
        public Student() {}
        public void GetStudentInformations() {
            Console.WriteLine("********* Student Informations *********");
            Console.WriteLine("Student Name: {0}", this.Name);
            Console.WriteLine("Student Surname: {0}", this.Surname);
            Console.WriteLine("Student No: {0}", this.No);
            Console.WriteLine("Student Category: {0}", this.Category);
        }
        public void IncreaseCategory() {
            this.Category = this.Category + 1;
        }
        public void DecreaseCategory() {
            this.Category = this.Category - 1;
        }
    }
}