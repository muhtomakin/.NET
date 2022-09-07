using System;

namespace variables{
    class Program {
        static void Main(string[] args) {
            try {
                Console.WriteLine("Enter an integer:");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Your number is:" + number);
            } catch (Exception ex) {
                Console.WriteLine("Error:" + ex.Message.ToString());
            } finally { // optional block
                Console.WriteLine("Process done!");
            }

            try {
                int a = int.Parse(null);
                int b = int.Parse("test");
                int c = int.Parse("-20000000000");
            } catch (ArgumentNullException ex) {
                Console.WriteLine("Empty enterance!!");
                Console.WriteLine("Error:" + ex.Message.ToString());
            } catch (FormatException ex) { // optional block
                Console.WriteLine("Type of data is wrong!!!");
                Console.WriteLine(ex);
            } catch (OverflowException ex) { // optional block
                Console.WriteLine("Too small or to big value is entered!!!");
                Console.WriteLine(ex);
            } finally { 
                Console.WriteLine("Process done!");
            }

        }
    }
}