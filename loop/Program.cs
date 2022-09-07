using System;

namespace variables{
    class Program {
        static void Main(string[] args) {
            int counter = int.Parse(Console.ReadLine());
            int number = int.Parse(Console.ReadLine());
            for (i = 1; i <= counter; i++) {
                if (i%2 == 1) {
                    Console.WriteLine(i);
                }
            }
            int evenTotal = 0;
            int oddTotal = 0;
            for (int i = 1; i<= 1000; i++) {
                if(i%2==1) {
                    oddTotal += i;
                } else {
                    evenTotal += i;
                }
            }

            Console.WriteLine("Odd Total:" + oddTotal);
            Console.WriteLine("Even Total:" + evenTotal);


            int c = 1;
            int total = 0;
            while(c <= number) {
                total += c;
                c++; 
            }
            Console.WriteLine("Total:" + total);

            string[] cars = {"BMW", "Ford", "Toyota", "Nissan"};
            foreach (var item in cars) {
                Console.WriteLine(item);
            }
        }
    }
}