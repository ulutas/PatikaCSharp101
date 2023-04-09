using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    class Board
    {
        public List<Card> toDo;
        public List<Card> inProgress;
        public List<Card> done;

        public Board()
        {
            toDo = new List<Card>();
            inProgress = new List<Card>();
            done = new List<Card>();
        }

        public void listBoard(Board b1)
        {
            Console.WriteLine("\nTODO Line\n************************");
            foreach (var item in b1.toDo)
            {
                Console.WriteLine("Title: {0}", item.Title);
                Console.WriteLine("Content: {0}", item.Content);
                Console.WriteLine("Assigned person: {0}", item.AssignedPerson);
                Console.WriteLine("Size: {0}\n-", item.CardSize);
            }
            Console.WriteLine("\nIN PROGRESS Line\n************************");
            foreach (var item in b1.inProgress)
            {
                Console.WriteLine("Title: {0}", item.Title);
                Console.WriteLine("Content: {0}", item.Content);
                Console.WriteLine("Assigned person: {0}", item.AssignedPerson);
                Console.WriteLine("Size: {0}\n-", item.CardSize);
            }
            Console.WriteLine("\nDONE Line\n************************");
            foreach (var item in b1.done)
            {
                Console.WriteLine("Title: {0}", item.Title);
                Console.WriteLine("Content: {0}", item.Content);
                Console.WriteLine("Assigned person: {0}", item.AssignedPerson);
                Console.WriteLine("Size: {0}\n-", item.CardSize);
            }
        }

        public void addCard(Board b1, Member t1)
        {
            int lineFlag;
            string line;
            do
            { //invalid id case for line
                lineFlag = 1;
                Console.Write("Please enter which line you want to put the card -> todo, inProgress, done : ");
                line = Console.ReadLine();
                line = line.ToLower();
                if (!line.Equals("todo") && !line.Equals("inprogress") && !line.Equals("done"))
                {
                    Console.WriteLine("Please enter a valid line!");
                    lineFlag = 0;
                }
            } while (lineFlag != 1);

            Console.Write("Please enter title: ");
            string title = Console.ReadLine();
            Console.Write("Please enter content: ");
            string content = Console.ReadLine();

            Card.CardSizeType c1 = new Card.CardSizeType();
            int sizeFlag, size;
            do
            { //invalid id case for size
                sizeFlag = 1;

                Console.Write("Please enter size -> XS(1),S(2),M(3),L(4),XL(5): ");
                size = int.Parse(Console.ReadLine());
                if (size == 1)
                {
                    c1 = Card.CardSizeType.XS;
                }
                else if (size == 2)
                {
                    c1 = Card.CardSizeType.S;
                }
                else if (size == 3)
                {
                    c1 = Card.CardSizeType.M;
                }
                else if (size == 4)
                {
                    c1 = Card.CardSizeType.L;
                }
                else if (size == 5)
                {
                    c1 = Card.CardSizeType.XL;
                }
                else
                {
                    Console.WriteLine("Please enter a valid size!");
                    sizeFlag = 0;
                }
            } while (sizeFlag != 1);


            int idFlag, id;
            do
            { //invalid id case for id
                idFlag = 1;
                Console.Write("Please enter assigned person's id: ");
                id = int.Parse(Console.ReadLine());
                if (!t1.TeamMembers.ContainsKey(id))
                {
                    Console.WriteLine("Please enter a valid id!");
                    idFlag = 0;
                }
            } while (idFlag != 1);

            if (line.ToLower().Equals("todo"))
            {
                b1.toDo.Add(new Card(title, content, t1.TeamMembers[id], c1, line));
                Console.WriteLine("New card has been added to toDo List!");
            }
            else if (line.ToLower().Equals("done"))
            {
                b1.done.Add(new Card(title, content, t1.TeamMembers[id], c1, line));
                Console.WriteLine("New card has been added to done List!");
            }
            else
            {
                b1.inProgress.Add(new Card(title, content, t1.TeamMembers[id], c1, line));
                Console.WriteLine("New card has been added to inProgress List!");
            }
        }

        public void deleteCard(Board b1)
        {
            int choice = 2;
            do
            {
                Console.Write("\nPlease enter title of the card you want to delete: ");
                string title = Console.ReadLine();

                int found = 0;
                Card deletionCard = new Card(); //in For each block while iterating deletion causes an exception. So We are saving the card we want to delete after all the foreach blocks we are deleting directly the card.
                foreach (var item in b1.toDo)
                {
                    if (item.Title.Equals(title))
                    {
                        found = 1;
                        Console.WriteLine("Deleting the card titled '{0}'", title);
                        deletionCard = item; //saving the card we want to delete
                        choice = 1; //for exiting the loop directly as we deleted.
                    }
                }
                foreach (var item in b1.inProgress)
                {
                    if (item.Title.Equals(title))
                    {
                        found = 2;
                        Console.WriteLine("Deleting the card titled '{0}'", title);
                        deletionCard = item; //saving the card we want to delete
                        choice = 1; //for exiting the loop directly as we deleted.
                    }
                }
                foreach (var item in b1.done)
                {
                    if (item.Title.Equals(title))
                    {
                        found = 3;
                        Console.WriteLine("Deleting the card titled '{0}'", title);
                        deletionCard = item; //saving the card we want to delete
                        choice = 1; //for exiting the loop directly as we deleted.
                    }
                }
                if (found == 1) //Removing the card
                    b1.toDo.Remove(deletionCard);
                else if (found == 2)
                    b1.inProgress.Remove(deletionCard);
                else if (found == 3)
                    b1.done.Remove(deletionCard);

                int choiceFlag = 1;
                if (found == 0)
                {
                    do
                    {
                        Console.WriteLine("The card matching the criteria you are looking for was not found on the board. Please make a selection");
                        Console.WriteLine("* To end the deletion : (1)\n* To try again : (2)");
                        Console.Write("Your choice: ");
                        choiceFlag = int.Parse(Console.ReadLine());
                        if (choiceFlag == 1)
                            choice = 1; //for exiting the loop directly
                        if (choiceFlag != 1 && choiceFlag != 2)
                        {
                            Console.WriteLine("Please enter a valid choice!");
                            choiceFlag = 0;
                        }
                    } while (choiceFlag == 0);
                }
            } while (choice == 2);
        }

        public void carryCard(Board b1)
        {
            int finalFlag = 1;
            do
            {
                Console.Write("\nPlease enter title of the card you want to carry: ");
                string title = Console.ReadLine();

                int found = 0;
                Card carryCard = new Card();

                int line = 1, lineFlag = 1;
                foreach (var item in b1.toDo)
                {
                    if (item.Title.Equals(title))
                    {
                        found = 1;
                        Console.WriteLine("\nFound card information: ");
                        Console.WriteLine("Title: {0}", item.Title);
                        Console.WriteLine("Content: {0}", item.Content);
                        Console.WriteLine("Assigned person: {0}", item.AssignedPerson);
                        Console.WriteLine("Size: {0}", item.CardSize);
                        Console.WriteLine("Line: {0}\n", item.Line);
                        carryCard = item; //saving the card we want to carry
                        Console.WriteLine("Please select the line you want to move the card to:");
                        do
                        {
                            lineFlag = 1;
                            Console.WriteLine("(1) TODO\n(2) IN PROGRESS\n(3) DONE");
                            Console.Write("Your choice: ");
                            line = int.Parse(Console.ReadLine());
                            if (line == 1)
                            {
                                Console.WriteLine("\nThe card is already in toDo Line!");
                                lineFlag = 0;
                            }
                            else if (line != 2 && line != 3)
                            {
                                Console.WriteLine("Please enter a valid line!");
                                lineFlag = 0;//for repeating the loop
                            }
                        } while (lineFlag == 0);
                    }
                }

                foreach (var item in b1.inProgress)
                {
                    if (item.Title.Equals(title))
                    {
                        found = 2; //inProgress
                        Console.WriteLine("\nFound card information: ");
                        Console.WriteLine("Title: {0}", item.Title);
                        Console.WriteLine("Content: {0}", item.Content);
                        Console.WriteLine("Assigned person: {0}", item.AssignedPerson);
                        Console.WriteLine("Size: {0}", item.CardSize);
                        Console.WriteLine("Line: {0}\n", item.Line);
                        carryCard = item; //saving the card we want to carry
                        Console.WriteLine("Please select the line you want to move the card to:");
                        do
                        {
                            lineFlag = 1;
                            Console.WriteLine("(1) TODO\n(2) IN PROGRESS\n(3) DONE");
                            Console.Write("Your choice: ");
                            line = int.Parse(Console.ReadLine());
                            if (line == 2)
                            {
                                Console.WriteLine("\nThe card is already in inProgress Line!");
                                lineFlag = 0;
                            }
                            if (line != 1 && line != 3)
                            {
                                Console.WriteLine("Please enter a valid line!");
                                lineFlag = 0;//for repeating the loop
                            }
                        } while (lineFlag == 0);
                    }
                }

                foreach (var item in b1.done)
                {
                    if (item.Title.Equals(title))
                    {
                        found = 3; //done
                        Console.WriteLine("\nFound card information: ");
                        Console.WriteLine("Title: {0}", item.Title);
                        Console.WriteLine("Content: {0}", item.Content);
                        Console.WriteLine("Assigned person: {0}", item.AssignedPerson);
                        Console.WriteLine("Size: {0}", item.CardSize);
                        Console.WriteLine("Line: {0}\n", item.Line);
                        carryCard = item; //saving the card we want to carry
                        Console.WriteLine("Please select the line you want to move the card to:");
                        do
                        {
                            lineFlag = 1;
                            Console.WriteLine("(1) TODO\n(2) IN PROGRESS\n(3) DONE");
                            Console.Write("Your choice: ");
                            line = int.Parse(Console.ReadLine());
                            if (line == 3)
                            {
                                Console.WriteLine("\nThe card is already in done Line!");
                                lineFlag = 0;
                            }
                            if (line != 1 && line != 2)
                            {
                                Console.WriteLine("Please enter a valid line!");
                                lineFlag = 0;//for repeating the loop
                            }
                        } while (lineFlag == 0);
                    }
                }

                if (found == 1)
                { //to do 
                    b1.toDo.Remove(carryCard); //first removing
                    if (line == 2)
                        b1.inProgress.Add(carryCard); //then adding
                    else if (line == 3)
                        b1.done.Add(carryCard);
                }
                else if (found == 2)
                { //inProgress
                    b1.inProgress.Remove(carryCard);
                    if (line == 1)
                        b1.toDo.Add(carryCard);
                    else if (line == 3)
                        b1.done.Add(carryCard);
                }
                else if (found == 3)
                { //done
                    b1.done.Remove(carryCard);
                    if (line == 1)
                        b1.toDo.Add(carryCard);
                    else if (line == 2)
                        b1.inProgress.Add(carryCard);
                }

                int choiceFlag = 1, choice;
                if (found == 0)
                {
                    do
                    {
                        Console.WriteLine("The card matching the criteria you are looking for was not found on the board. Please make a selection");
                        Console.WriteLine("* To end the moving : (1)\n* To try again : (2)");
                        Console.Write("Your choice: ");
                        choice = int.Parse(Console.ReadLine());
                        if (choice == 1)
                        {
                            choiceFlag = 0; //for exiting the inner loop directly
                            finalFlag = 0; //for exiting the outer loop directly
                        }
                        else if (choice == 2)
                            choiceFlag = 0; // if it is 2 just exit the inner loop
                        else
                        {
                            Console.WriteLine("Please enter a valid choice!");
                            choiceFlag = 1; //continue to ask valid choice
                        }
                    } while (choiceFlag == 1);
                }
                else
                {
                    if (line == 1) //for output 
                        Console.WriteLine("Your card has been moved to toDo line successfully!");
                    else if (line == 2)
                        Console.WriteLine("Your card has been moved to inProgress line successfully!");
                    else if (line == 3)
                        Console.WriteLine("Your card has been moved to done line successfully!");
                    finalFlag = 0; // the card already found so just exit the outer loop too.
                }
            } while (finalFlag == 1);

        }
    }
}
