using System;
using System.Collections;
using System.Collections.Generic;

namespace arraylist {
    class Program {
        static void Main(string[] args) {
           // System.Collections

           ArrayList list = new ArrayList();
           list.Add("Toma");
           list.Add(2);
           list.Add(true);
           list.Add('A');

           string[] colors = { "Red", "Yellow", "Green" };
           List<int> numbers = new List<int>(){1, 5, 6, 3, 8, 7};
           list.AddRange(colors);
           list.AddRange(numbers);

           // Sort
           Console.WriteLine("**** Sort ****");
           // Cannot sort list
           ArrayList list2 = new ArrayList();
           list2.AddRange(numbers);
           list2.Sort();


        }
    }
}

