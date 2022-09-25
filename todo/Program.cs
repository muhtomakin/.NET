using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todo {
    public class Program {
        static void Main(string[] args) {
            while (true) {
                string select = Board.menu();
                if (select == "1") {
                    Board.list();
                }else if (select == "2")
                {
                    Card newCard = Board.createCard();
                    Board.cardAdd(newCard);
                }
                else if (select == "3")
                {
                    Card newCard = Board.createCard();
                    Board.cardUpdate(newCard);
                }
                else if (select == "4")
                {
                    Board.cardDelete();
                }
                else if (select == "5")
                {
                    Board.cardMove();
                }
                else if (select == "6")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong input!");
                }
            }
        }
    }
}