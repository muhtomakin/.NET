using System;
using System.Collections.Generic;

namespace todo {
    static class Board {
        private static List<Card> todo = new List<Card>();
        private static List<Card> progress = new List<Card>();
        private static List<Card> done = new List<Card>();

        public static string menu() {
            Console.WriteLine("Please select the process from menu.");
            Console.WriteLine("******************************************* ");
            Console.WriteLine("(1) List Board ");
            Console.WriteLine("(2) Add a Card to Board ");
            Console.WriteLine("(3) Update Card ");
            Console.WriteLine("(4) Delete Card from Board ");
            Console.WriteLine("(5) Change Card ");
            Console.WriteLine("(6) Exit ");

            string choice = Console.ReadLine();
            return choice;
        }

        public static Card createCard() {
            Console.Write("Enter a Headline                           : ");
            string headline = Console.ReadLine();
            Console.Write("Enter a context                            : ");
            string context = Console.ReadLine();
            Console.Write("Choose Size -> XS(1),S(2),M(3),L(4),XL(5)  : ");
            string size = Console.ReadLine();
            Console.Write("Choose Person                              : ");
            string person = Console.ReadLine();

            Card newCard = new Card(headline, context, size, person);
            return newCard;
        }

        public static void listBoard(string boardLine) {
            Console.WriteLine("{0} Line",boardLine);
            Console.WriteLine("************************");

            (boardLine=="TODO" ? todo: boardLine == "PROGRESS" ? progress:done).ForEach(item => {
                Console.WriteLine(" Headline      : {0}", item.Headline);
                Console.WriteLine(" Context      : {0}", item.Context);
                Console.WriteLine(" Person : {0}", item.Person);
                Console.WriteLine(" Size    : {0}", item.Size);
                Console.WriteLine("----------------");
            });
        }

        public static void list() {
            listBoard("TODO");
            listBoard("PROGRESS");
            listBoard("DONE");
        }

        public static void cardAdd(Card record) {
            todo.Add(record);
        }

        public static void cardUpdate(Card record) {
            Card toUpdateCard = todo.Find(item => item.Headline == record.Headline);
            toUpdateCard.Context = record.Context;
            toUpdateCard.Size = record.Size;
            toUpdateCard.Person = record.Person;
        }

        public static void cardDelete() {
            Console.WriteLine("Select the card that want to delete.");
            Console.Write("Please enter card headline:  ");
            string headline = Console.ReadLine();
            Card toDeleteCard = todo.Find(card => card.Headline == headline);
            todo.Remove(toDeleteCard);
            progress.Remove(toDeleteCard);
            done.Remove(toDeleteCard);
        }

        public static void cardMove() {
            Console.WriteLine("Select the card that want to move.");
            Console.Write("Please enter card headline:  ");
            string headline = Console.ReadLine();
            Card toMoveCard = todo.Find(card => card.Headline == headline);
            if (toMoveCard == null) 
            {
                toMoveCard = progress.Find(card => card.Headline == headline);
                progress.Remove(toMoveCard);
                done.Add(toMoveCard);
            }
            else
            {
                todo.Remove(toMoveCard);
                progress.Add(toMoveCard);
            }
        }
        enum Size
        {
            XS ,
            S,
            M,
            L,
            XL
        }
    }
}