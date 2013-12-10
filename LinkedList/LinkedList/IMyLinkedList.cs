using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    interface IMyLinkedList<T>
    {
        void AddToFront(T element);
        void AddToBack(T element);
        T ViewFrontElement();
        T ViewBackElement();
        MyLinkedList<T>.Element RemoveFrontElement();
        MyLinkedList<T>.Element RemoveBackElement();
        void ShowAllElements();        
        void ClearList();
        int Size { get; }
    }
}
