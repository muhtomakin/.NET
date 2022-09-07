using System;

namespace variables{
    class Program {
        static void Main(string[] args) {
            int time = DateTime.Now.Hour;
            if ( time >= 6 && time < 11 ) {
                Console.WriteLine("Good Morning!!");
            } else if (time <= 18 ){
                Console.WriteLine("Have a good day!");
            } else {
                Console.WriteLine("Have a good night!");
            }

            string result = time >= 8 && time < 11 ? "Good morning!" : time <= 18 ? "have a good day" : "good night";
            Console.WriteLine(result);
        }
    }
}