using System;

namespace methodoverloading{
    class Program {
        static void Main(string[] args) {
            string number = "999";
            bool result = int.TryParse(number, out int outNumber);

            if (result) {
                Console.WriteLine("Success!");
                Console.WriteLine(outNumber);
            } else {
                Console.WriteLine("Failed!");
            }

            Methods instance = new Methods();
            instance.Total(4, 5, out int totalResult);
            Console.WriteLine(totalResult);

            int i = 999;
            instance.PrintScreen(Convert.ToString(i));
            instance.PrintScreen(i);
            instance.PrintScreen("Toma", "Toma");
        }           
    } 

    class Methods {
        public void Total(int a, int b, out int total) {
            total = a + b;
        }
        public void PrintScreen(string data) {
            Console.WriteLine(data);
        }
        public void PrintScreen(int data) {
            Console.WriteLine(data);
        }

        public void PrintScreen(string data1, string data2) {
            Console.WriteLine(data1 + data2);
        }
    } 
}