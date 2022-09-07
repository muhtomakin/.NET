using System;

namespace variables{
    class Program {
        static void Main(string[] args) {
            int month = DateTime.Now.Month;
            switch (month) {
                case 1:
                    Console.WriteLine("January");
                    Console.WriteLine("Winter");
                    break;
                case 2:
                    Console.WriteLine("February");
                    Console.WriteLine("Winter");
                    break;
                case 3:
                    Console.WriteLine("March");
                    Console.WriteLine("Spring");
                    break;
                case 4:
                    Console.WriteLine("April");
                    Console.WriteLine("Spring");
                    break;
                case 5:
                    Console.WriteLine("May");
                    Console.WriteLine("Spring");
                    break;
                case 6:
                    Console.WriteLine("June");
                    Console.WriteLine("Summer");
                    break;
                case 7:
                    Console.WriteLine("July");
                    Console.WriteLine("Summer");
                    break;
                case 8:
                    Console.WriteLine("August");
                    Console.WriteLine("Summer");
                    break;
                case 9:
                    Console.WriteLine("September");
                    Console.WriteLine("Autumn");
                    break;
                case 10:
                    Console.WriteLine("October");
                    Console.WriteLine("Autumn");
                    break;
                case 11:
                    Console.WriteLine("November");
                    Console.WriteLine("Autumn");
                    break;
                case 12:
                    Console.WriteLine("December");
                    Console.WriteLine("Winter");
                    break;
                default:
                    break;
            }
        }
    }
}