using System;
// John Cheney
// IT113
// NOTES: I had trouble trying to figure out how to set the "Search" option back to Head without resetting the entire list to null if the word didn't exist so I made a temp Node to hold the return to avoid that happening
// I originally tried to do the same with the remove method, but after trying a few things I had to ask for help from Ethan on what would make it work. I got a mostly workable version where the only item that can't be deleted
// is the first item in the Linked list. 
// BEHAVIORS NOT IMPLEMENTED AND WHY: Cannot delete the first Node in the LinkedList. All other behaviors implemented.
namespace Cheney_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Node Head = null;
            Linked_list LL = new Linked_list();
            ConsoleKeyInfo entry;
            Console.WriteLine("Welcome. Please select a number to get started.");
            bool Escape = false;
            do
            {
                Console.WriteLine("1. Add item");
                Console.WriteLine("2. Search item");
                Console.WriteLine("3. Remove item");
                Console.WriteLine("4. Print list");
                Console.WriteLine("5. Exit");
                entry = Console.ReadKey();
                Console.Clear();
                if (entry.Key == ConsoleKey.NumPad1 || entry.Key == ConsoleKey.D1)
                {
                    Console.WriteLine("Enter word to add to list");
                    string Nodeitem = Console.ReadLine();
                    Head = LL.Add(Head, new Node(Nodeitem));
                    Console.WriteLine("Item added to Node. Press any key to return");
                    Console.ReadKey();
                    Console.Clear();
                    
                }
                if (entry.Key == ConsoleKey.NumPad2 || entry.Key == ConsoleKey.D2)
                {
                    Console.WriteLine("Enter word to search in list");
                    string Nodeitem = Console.ReadLine();
                    Node test= LL.Contains(Head, Nodeitem);
                    if(test != null)
                    {
                        Console.WriteLine("Item is listed in Node " + test.Datas);
                    }
                    else
                    {
                        Console.WriteLine("Item does not exist in nodes");
                    }
                    Console.WriteLine("Press any key to return.");
                    Console.ReadKey();
                    Console.Clear();
                }
                if (entry.Key == ConsoleKey.NumPad3 || entry.Key == ConsoleKey.D3)
                {
                    Console.WriteLine("Enter word to search an item to delete from list");
                    string Nodeitem = Console.ReadLine();
                    LL.Remove(Head, Nodeitem, out bool isitnull);
                    if (isitnull != true)
                    {
                        Console.WriteLine("Item in Node removed");
                    }
                    else
                    {
                        Console.WriteLine("Item does not exist in nodes");
                    }
                    Console.WriteLine("Press any key to return.");
                    Console.ReadKey();
                    Console.Clear();
                }
                if (entry.Key == ConsoleKey.NumPad4 || entry.Key == ConsoleKey.D4)
                {
                    Console.WriteLine("Node items:");
                    LL.PrintAll(Head);
                    Console.WriteLine("Press any key to return.");
                    Console.ReadKey();
                    Console.Clear();
                }
                if (entry.Key == ConsoleKey.NumPad5 || entry.Key == ConsoleKey.D5)
                {
                    Console.WriteLine("Press any key to terminate application");
                    Escape = true;
                    Console.ReadKey();
                }



            } while (Escape != true);
                    
        }
    }
}
