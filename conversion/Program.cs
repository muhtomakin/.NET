using System;

namespace variables{
    class Program {
        static void Main(string[] args) {
            // Implicit
            byte a = 3;
            sbyte b = 30;
            short c = 10;
            int d = a+b+c;
            Console.WriteLine("d:" + d);

            long h = d;
            Console.WriteLine("h:" + h);

            float i = h;
            Console.WriteLine("i:" + i);

            string s = "toma";
            char f = "k";
            object g = s+f+d;
            Console.WriteLine("g:" + g);

            // Explicit
            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y:" + y);

            int z = 100;
            byte t = (byte)z;
            Console.WriteLine("t:" + t);

            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("v:" + v);

            // ToString
            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy:" + yy);

            string zz = 12.5f.ToString();
            Console.WriteLine("zz:" + zz);

            // System.Convert
            string s1 = "10", s2 = "20";
            int int1, int2;
            int result;

            int1 = Convert.ToInt32(s1);
            int2 = Convert.ToInt32(s2);

            result = int1 + int2;
            Console.WriteLine("result:" + result);

            // Parse
            ParseMethod();
        }
        public static void ParseMethod() {
            string text1 = "10";
            string text2 = "10.25";
            int digit1;
            double double1;
            digit1 = Int32.Parse(text1);
            double1 = Double.Parse(text2);

            Console.WriteLine("digit1:" + digit1);
            Console.WriteLine("double1:" + double1);
        }
    }
}