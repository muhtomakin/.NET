using System;

namespace static_class {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Employee Count: {0}", Employee.EmployeeCount);

            Employee employee = new Employee("Toma", "Müller", "HR");
            Console.WriteLine("Employee Count: {0}", Employee.EmployeeCount);
        }
    }
    class Employee {
        private static int employeeCount;
        public static int EmployeeCount { get => employeeCount; }
        private string Name;
        private string Surname;
        private string Department;
        static Employee() {
            employeeCount = 0;
        }
        public Employee(string name, string surname, string department) {
            this.Name = name;
            this.Surname = surname;
            this.Department = department;
            employeeCount++;
        }
    }
}