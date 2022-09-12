using System;
using System.Collections;
using System.Collections.Generic;

namespace homework2 {
    class Program {
        static void Main(string[] args) {
           
        }
    }
    class Questions {
        public void question1() {
            List<int> numbers = creatingList();

            List<int> primeNumbers = new List<int>();
            List<int> nonPrimeNumbers = new List<int>();

            List<int> primeNumbersLowerSeventeen = new List<int>() { 2, 3, 5, 7, 11, 13 };

            foreach (int i in numbers) {
                if (i < 17) {
                    if (primeNumbersLowerSeventeen.Contains(i)) primeNumbers.Add(i);
                    else nonPrimeNumbers.Add(i);
                } else {
                    if (((i + 1) % 6 == 0) | ((i - 1) % 6 == 0)) primeNumbers.Add(i);
                    else nonPrimeNumbers.Add(i);
                }
            }

            PrintScreen(primeNumbers, "Prime Numbers");
            PrintScreen(nonPrimeNumbers, "Non Prime Numbers");
        }

        public void question2() {
            List<int> numbers = creatingList();
            List<int> maxNums = new List<int>();
            List<int> minNums = new List<int>();
            for (int j = 0; j < 3; j++)
            {
                int maxNum = numbers.Max();
                Console.WriteLine("Maximum element " + maxNum);
                maxNums.Add(maxNum);
                maxNums.Remove(maxNum);

                int minNum = numbers.Min();
                Console.WriteLine("Minimum element " + minNum);
                minNums.Add(minNum);
                minNums.Remove(minNum);
            }
            Console.WriteLine("Numbers");
            foreach (int k in nums) Console.WriteLine(k);

            Console.WriteLine("Maximum Numbers");
            foreach (int k in maxNums) Console.WriteLine(k);

            Console.WriteLine("Minimum Numbers");
            foreach (int k in minNums) Console.WriteLine(k);
        }
        public void question3() {
            Console.WriteLine("Give me a sentence");
            string sentence = Console.ReadLine();
            string pattern = @"[aeıuüioö]";
            Regex rg = new Regex(pattern);
            MatchCollection vowelSounds = rg.Matches(sentence);
            foreach (Match match in vowelSounds) Console.WriteLine(match);
        }
        public List<int> creatingList() {
            List<int> numbers = new List<int>();
            Console.WriteLine("Write a number: ");
            for (var i = 0; i < 20; i++) {
                while (true) {
                    string n = Console.ReadLine();
                    try {
                        int num = int.Parse(n);
                        if (num <= 0) throw new Exception("Input type must be an integer and higher than zero");
                        else {
                            numbers.Add(num);
                            break;
                        }
                    } catch (Exception e) {
                        Console.WriteLine(e.Message);
                    }
                }
            }
            return numbers;
        }

        public void printScreen(List<int> list, String str) {
            Console.WriteLine("***** " + str + " *****");
            foreach (var i in list.OrderBy(x => x)) Console.WriteLine(i.ToString() + " ");
            Console.WriteLine(str + " Avarage: " + ((float)list.Sum() / (float)list.Count()).ToString());
        }
    }
}

