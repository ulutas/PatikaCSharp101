using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Member t1 = new Member(); //creating members
            t1.TeamMembers.Add(1, "Ömer Ulutaş"); //adding team members by default
            t1.TeamMembers.Add(2, "Hayati Durmaz");
            t1.TeamMembers.Add(3, "Kaderim Sensin");
            Board b1 = new Board(); //creating a board
            b1.toDo.Add(new Card("Back-end problem", "Occuring 404 problem", t1.TeamMembers[1], Card.CardSizeType.XS, "toDo")); //Adding 3 cards to board by default

            b1.inProgress.Add(new Card("Front-end problem", "Connection between backend-frontend", t1.TeamMembers[2], Card.CardSizeType.S, "inProgress"));
            b1.inProgress.Add(new Card("AI problem", "Accuracy problem on AI", t1.TeamMembers[3], Card.CardSizeType.XL, "inProgress"));
            int choice;
            do
            {
                Console.WriteLine("\nPlease select the action you want to do :)");
                Console.WriteLine("******************************");
                Console.WriteLine("(1) List your board\n(2) Add a card to your board\n(3) Delete a card from your board\n(4) Carry your card\n(5) Exit");
                Console.Write("Your choice: ");
                choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                    b1.listBoard(b1);
                else if (choice == 2)
                    b1.addCard(b1, t1);
                else if (choice == 3)
                    b1.deleteCard(b1);
                else if (choice == 4)
                    b1.carryCard(b1);
                else if (choice == 5)
                    Console.WriteLine("Bye!!!");
                else
                    Console.WriteLine("Please enter a valid choice!");

            } while (choice != 5);
        }
    }
}
