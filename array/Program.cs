using System;

namespace variables{
    class Program {
        static void Main(string[] args) {
            string[] colors = new string[5];
            string[] animals = {"Cat", "Dog", "Bird", "Monkey"};

            int[] arr;
            arr = new int[5];

            colors[0] = "Blue";
            arr[3] = 10;

            Console.WriteLine(animals[1]);
            Console.WriteLine(arr[3]);
            Console.WriteLine(colors[0]);

            Console.WriteLine("Enter array length:");
            int arrLength = int.Parse(Console.ReadLine());
            int[] intArr = new int[arrLength];

            for (int i = 0; i < arrLength; i++) {
                Console.Write("Please enter {0}. number:", i+1);
                intArr[i] = int.Parse(Console.ReadLine());
            }

            int total = 0;
            foreach (var number in intArr) {
                total += number;
            }

            Console.WriteLine("Avarage: " + total/arrLength);

            int[] intArrSec = {12, 11, 3, 67, 3, 17};

            foreach (var number in intArrSec) {
                Console.WriteLine(number);
            }

            Array.Sort(intArrSec);
            foreach (var number in intArrSec) {
                Console.WriteLine(number);
            }

            Array.Clear(intArrSec, 2, 2);
            foreach (var number in intArrSec) {
                Console.WriteLine(number);
            }
        }
    }
}