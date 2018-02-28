using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueStacker
{
    class Program
    {
        static void Main(string[] args)
        {

            GameStack stack = new GameStack();
            GameQueue queue = new GameQueue();
            Console.WriteLine("Putting the following spells on the stack...\n-Doomsday\n-Pact of Negation\n-Force of Will\n-Mindbreak Trap\n-Repeal");
            stack.Push("Doomsday");
            stack.Push("Pact of Negation");
            stack.Push("Force of Will");
            stack.Push("Mindbreak Vault");
            stack.Push("Repeal");

            Console.WriteLine();
            Console.WriteLine("The spells resolve in the following order:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("-"+stack.Pop());
            }

            Console.WriteLine();
            Console.WriteLine("The following players are joining the queue...\n-Zera\n-Lei\n-Ceru\n-Xeian\n-Tynal");
            queue.Enqueue("Zera");
            queue.Enqueue("Lei");
            queue.Enqueue("Ceru");
            queue.Enqueue("Xeian");
            queue.Enqueue("Tynal");

            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("\"" + queue.Dequeue() + "\" has joined the server: " + queue.Count + " player(s) left in queue");
            }



            GameStack back = new GameStack();
            GameStack forward = new GameStack();
            bool breaker = false;
            string currentPage = null;
            do
            {
                Console.WriteLine("What Would you like to do?\n1: Visit a new webpage\n2: Move forward a page\n3: Move back a page\nPrint the current page, and back and forward stacks\n5: Quit");
                string switcher = Console.ReadLine().Trim();
                switch (switcher)
                {
                    case ("1"):
                        VisitPage();
                        break;
                    case ("2"):
                        MoveForward();
                        break;
                    case ("3"):
                        MoveBack();
                        break;
                    case ("4"):
                        GameStack tempBack = new GameStack();
                        for (int i = 0; i < 5; i++)
                        {
                            string tempPage = back.Pop();
                            tempBack.Push(tempPage);
                            Console.WriteLine(tempPage);
                        }
                        for (int i = 0; i < 5; i++)
                        {
                            back.Push(tempBack.Pop());

                        }
                        break;
                    case ("5"):
                        breaker = true;
                        break;
                }
            }
            while (breaker == false);
            
            void VisitPage()
            {
                Console.WriteLine("Enter the URL");
                if (currentPage != null)
                {
                    back.Push(currentPage);
                }
                currentPage = Console.ReadLine().Trim();
            }

            void MoveForward()
            {
                if (!forward.IsEmpty)
                {
                    back.Push(currentPage);
                    currentPage = forward.Pop();

                }
                else
                {
                    Console.WriteLine("You can not go any further forward");
                }
            }

            void MoveBack()
            {
                if (!back.IsEmpty)
                {
                    forward.Push(currentPage);
                    currentPage = back.Pop();

                }
                else
                {
                    Console.WriteLine("You can not go any further back");
                }
            }

        }
    }
}
