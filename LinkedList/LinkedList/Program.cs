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

            NewList.AddToFront(1);
            NewList.AddToFront(2);
            NewList.AddToFront(3);
            NewList.AddToBack(4);
            NewList.AddToBack(5);
            NewList.AddToBack(6);

            NewList.ShowAllElements();
            
            Console.WriteLine("List has " + NewList.Size + " elements");

            Console.WriteLine("first element: " + NewList.ViewFrontElement());

            Console.WriteLine("last element: " + NewList.ViewBackElement());

            Console.WriteLine("removing first 2 elements: ");

            Console.WriteLine("removed element: " + NewList.RemoveFrontElement().Value);
            Console.WriteLine("removed element: " + NewList.RemoveFrontElement().Value);

            NewList.ShowAllElements();

            Console.WriteLine("List has " + NewList.Size + " elements");

            Console.WriteLine("removing the last element: ");

            Console.WriteLine("removed element: " + NewList.RemoveBackElement().Value);

            NewList.ShowAllElements();

            Console.WriteLine("List has " + NewList.Size + " elements");

            

            Console.WriteLine("clearing the list..");

            NewList.ClearList();
            

            try
            {
                NewList.ShowAllElements();
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message); 
            }
            Console.WriteLine("Trying to delete last element:");

            try
            {
                NewList.RemoveBackElement();
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("error: " + e.Message);
            }

            Console.ReadLine();
        }
    }
}
