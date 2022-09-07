using System;

namespace variables{
    class Program {
        static void Main(string[] args) {
            // reach_indicator back_type method_name(argument/parameter) {
                // commands;
                // return;
            // }
            int a = 2;
            int b= 3;
            Console.WriteLine(a+b);

            int total = Total(a, b);
            Console.WriteLine(total);

            Methods example = new Methods();
            example.PrintScreen(Convert.ToString(total));

            int result = example.IncreaseTotal(ref a, ref b);
            example.PrintScreen(Convert.ToString(result));
            example.PrintScreen(Convert.ToString(a+b));
        }

        static int Total(int value1, int value2) {
            return (value1 + value2);
        }
    }

    class Methods {
        public void PrintScreen(string data) {
            Console.WriteLine(data);
        }

        public int IncreaseTotal(ref int value1, ref int value2) {
            value1 += 1;
            value2 += 1;
            return value1 + value2;
        }
    }
}