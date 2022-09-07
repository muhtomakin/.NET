using System;

namespace recursiveextension{
    class Program {
        static void Main(string[] args) {
            int result = 1;
            for (int i = 1; i < 5; i++) 
                result = result * 3;
            Console.WriteLine(result);
            Process instance = new();
            Console.WriteLine(instance.Expo(3,4));

            string expression = "Muhammed Tomakin";
            bool result2 = expression.CheckSpaces();
            Console.WriteLine(result2);

            if (result2) 
                Console.WriteLine(expression.RemoveWhiteSpaces());
            
            Console.WriteLine(expression.MakeUpperCase());
            Console.WriteLine(expression.MakeLowerCase());

            int[] arr = {9, 8, 1, 5, 2, 7};
            arr.SortArray();
            arr.PrintScreen();

            int number = 5;
            Console.WriteLine(number.IsEven());

            Console.WriteLine(expression.GetFirstCharacter());
        }           
    } 

    public class Process {
        public int Expo(int number, int ex) {
            if (ex < 2) 
                return number;
            return Expo(number, number-1) * number;
        }
    }

    public static class Extension {
        public static bool CheckSpaces(string param) {
            return param.Contains(" ");
        }
        public static string RemoveWhiteSpaces(this string param) {
            string[] arr = param.Split(" ");
            return string.Join("", arr);
        }
        public static string MakeUpperCase(this string param) {
            return param.ToUpper();
        }
        public static string MakeLowerCase(this string param) {
            return param.ToLower();
        }
        public static int[] SortArray(this int[] param) {
            Array.Sort(param);
            return param;
        }
        public static void PrintScreen(this int[] param) {
            foreach(int item in param) 
                Console.WriteLine(item);
        }
        public static bool IsEven(this int param) {
            return param%2 == 0;
        }
        public static string GetFirstCharacter(this string param) {
            return param.Substring(0, 1);
        }
    } 
}