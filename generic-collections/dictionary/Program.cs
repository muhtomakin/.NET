using System;
using System.Collections.Generic;

namespace dictionary {
    class Program {
        static void Main(string[] args) {
            // System.Collections.Generic

            Dictionary<int, string> users = new Dictionary<int, string>();
            users.Add(10, "Christoph Müller");
            users.Add(12, "Toma Müller");

            // Count
            Console.WriteLine(users.Count);

            // Contains 
            Console.WriteLine(users.ContainsKey(12));
            Console.WriteLine(users.ContainsValue("Toma Müller"));
        }
    }
}

