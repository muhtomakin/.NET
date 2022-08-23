using System;

namespace variables{
    class Program {
        static void Main(string[] args) {
            int a = 2;
            string b = null;
            string B = null;
            Console.WriteLine(a + " " + B + " " +  b);
            String c = " ";
            byte d = 5;         // 1 byte
            sbyte e = 5;        // 1 byte
            short s = 5;        // 2 byte
            ushort us = 5;      // 2byte

            Int16 i16 = 2;      // 2 byte
            int i = 2;          // 4 byte
            Int32 i32 = 2;      // 4 byte
            Int64 i64 = 2;      // 8 byte

            uint ui = 2;        // 4 byte
            long l = 4;         // 8 byte
            ulong ul = 4;       // 8 byte

            float f = 5;        // 4 byte
            double dd = 4;      // 8 byte
            decimal de = 5;     // 16 byte

            char ch = '2';          // 2 byte
            string str = "Toma";    // unlimited
            bool b1 = true;         

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            object o1 = "x";
            object o2 = 'y';
            object o3 = 3;
            object o4 = 3.2;

            string str1 = string.Empty;
            str1 = "Toma";
            string name = "Toma";
            string surname = "Toma";
            string fullname = name + " " + surname;

            string str20 = "20";
            int int20 = 20;
            string newValue = str20 + int20.ToString();
            Console.WriteLine(newValue); // output 2020
            
            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21); // output 40

            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);
        }
    }
}