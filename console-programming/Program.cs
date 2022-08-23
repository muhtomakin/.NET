using System;

namespace console_programming {
    class Program {
        public static void Main(string[] args) {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your lastname:");
            string lastname = Console.ReadLine();
            Console.WriteLine("Your name is: " + name + " " + lastname);
        }
    }
}