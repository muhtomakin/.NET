using System;

namespace variables{
    class Program {
        static void Main(string[] args) {
            bool isSuccess = true;
            bool isCompleted = false;

            if(isSuccess && isCompleted) {
                Console.WriteLine("Perfect!");
            }

            if(isSuccess || isCompleted) {
                Console.WriteLine("Great!");
            }

            if(isSuccess && !isCompleted) {
                Console.WriteLine("Fine!");
            }

            int a = 3;
            int b = 4;
            bool result = a<b;
            Console.WriteLine(result);
            result = a>=b;
            Console.WriteLine(result);
        }
    }
}