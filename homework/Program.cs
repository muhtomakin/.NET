using System;

namespace homework {
    class Program {
        public static void Main(string[] args) {
            
        }
    }   
    class Questions {
        public void evenNumbersPrint() {
            Console.WriteLine("Enter a number:");
            int n = Console.ReadLine();
            List<int> numArr = new List<int>();
            for (int i = 0; i < n; i++) {
                int num = Console.ReadLine();
                if (num%2 == 0) numArr.Add(num);
            }

            foreach (var number in numArr) {
                Console.WriteLine(number);
            }
        }
        public void divisibleNumber() {
            Console.WriteLine("Divided bumber:");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("How many numbers:");
            int n = int.Parse(Console.ReadLine());

            List<int> numArr = new List<int>();

            for (int i = 0; i < n; i++) {
                Console.WriteLine("Enter number:");
                int num = int.Parse(Console.ReadLine());
                if (m%num == 0) numArr.Add(num);
            }

            foreach (var number in numArr) {
                Console.WriteLine(number);
            }
        }
        public void stringReversePrint() {
            Console.WriteLine("Enter words count:");
            int n = int.Parse(Console.ReadLine());

            List<string> words = new List<string>();

            for (int i = 0; i < n; i++) {
                Console.WriteLine("Enter a word:");
                string word = Console.ReadLine();
                words.Add(word);
            }

             for (int i = n - 1; i >= 0; i--) {
                Console.WriteLine(words[i]);
            }
        }
        public void wordLetterCount() {
            Console.WriteLine("Enter sentence:");
            string sentence = Console.ReadLine();

            string[] words = sentence.Split(' ');
            Console.WriteLine("Words count: {0}", words.Length);

            string newSentence = sentence.Replace(" ", "");
            string[] letters = newSentence.Split("");
            Console.WriteLine("Letters count: {0}", letters.Length);
        }
    } 
}