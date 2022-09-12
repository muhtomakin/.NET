using System;
using System.Collections.Generic;

namespace generic_list {
    class Program {
        static void Main(string[] args) {
            // List<T>
            // System.Collections.Generic
            // T -> object product

            List<int> intList = new List<int>();
            intList.Add(23);
            intList.Add(12);
            intList.Add(56);
            intList.Add(1);
            intList.Add(5);
            intList.Add(10);
            intList.Add(92);
            intList.Add(34);

            List<string> colorList = new List<string>();
            colorList.Add("Red");
            colorList.Add("Blue");
            colorList.Add("Orange");
            colorList.Add("Yellow");
            colorList.Add("Green");

            // count
            foreach (var number in intList)
                Console.WriteLine(number);
            foreach (var color in colorList)
                Console.WriteLine(color);

            colorList.ForEach(color => Console.WriteLine(color));
            intList.ForEach(number => Console.WriteLine(number));

            // Convert Array to List 
            string[] animals = {"Cat", "Dog", "Bird"};
            List<string> animalList = new List<string>(animals);

            animalList.Clear();

            //------//
            List<Users> userList = new List<Users>();
            Users user1 = new Users();
            user1.Name = "Christopf";
            user1.Name = "Müller";
            user1.Age = "27";

            Users user2 = new Users();
            user2.Name = "Tomakin";
            user2.Name = "Müller";
            user2.Age = "28";

            userList.Add(user1);
            userList.Add(user2);

            List<Users> newList = new List<Users>();            
            newList.Add(new Users(){
                Name = "Ege",
                Surname = "Toma",
                Age = 25,
            });

            foreach (var user in userList) {
                Console.WriteLine("User name", user.Name);
                Console.WriteLine("User surname", user.Surname);
                Console.WriteLine("User age", user.Age);
            }
        }
    }
    public class Users{
        private string name;
        private string surname;
        private int age;

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; } 
        public int Age { get => age; set => age = value; }
    }
}

