using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        public static void Main(string[] args)
        {
            MyLinkedList<int> NewList = new MyLinkedList<int>();

            Console.WriteLine("AddFirst 1, 2, 3; AddLast 4, 5, 6: ");

            NewList.AddFirst(1);
            NewList.AddFirst(2);
            NewList.AddFirst(3);
            NewList.AddLast(4);
            NewList.AddLast(5);
            NewList.AddLast(6);

            NewList.ShowAllElements();
            
            Console.WriteLine("List has " + NewList.Size + " elements");

            Console.WriteLine("first element: " + NewList.ViewFirst());

            Console.WriteLine("last element: " + NewList.ViewLast());

            Console.WriteLine("removing first 2 elements: ");

            NewList.RemoveFirst();
            NewList.RemoveFirst();

            NewList.ShowAllElements();

            Console.WriteLine("List has " + NewList.Size + " elements");

            Console.WriteLine("removing the last element: ");

            NewList.RemoveLast();

            NewList.ShowAllElements();

            Console.WriteLine("List has " + NewList.Size + " elements");

            Console.WriteLine("clearing the list..");

            NewList.ClearList();

            NewList.ShowAllElements();

            Console.WriteLine("Trying to delete last element:");

            try
            {
                NewList.RemoveLast();
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("error: " + e.Message);
            }

            Console.ReadLine();
        }
    }
}
