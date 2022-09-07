using System;

namespace homework {
    class Program {
        public static void Main(string[] args) {
            string variable = "Our lesson CSharp, Welcome";
            string variable2 = "our lesson CSharp, welcome";

            Console.WriteLine(variable.Length);

            Console.WriteLine(variable.ToUpper);
            Console.WriteLine(variable.ToLower);

            Console.WriteLine(String.Concat(variable, " Good morning!"));

            Console.WriteLine(variable.CompareTo(variable2));
            Console.WriteLine(String.Compare(variable, variable2, true));
            Console.WriteLine(String.Compare(variable, variable2, false));

            Console.WriteLine(variable.Contains(variable2));
            Console.WriteLine(variable.EndsWith("Welcome!"));
            Console.WriteLine(variable.StartsWith("Hello"));

            Console.WriteLine(variable.IndexOf("CS"));
            Console.WriteLine(variable.IndexOf("Toma"));
            Console.WriteLine(variable.LastIndexOf("i"));
            
            Console.WriteLine(variable.Insert(0, "Hello, "));
            
            Console.WriteLine(variable + variable2.PadLeft(30));
            Console.WriteLine(variable + variable2.PadLeft(30, "*"));

            Console.WriteLine(variable.Remove(10));

            Console.WriteLine(variable.Replace(" ", ""));
        }
    }    
}