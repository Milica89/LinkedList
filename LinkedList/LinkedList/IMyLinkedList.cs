using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    interface IMyLinkedList<T>
    {
        void AddFirst(T element);
        void AddLast(T element);
        T ViewFirst();
        T ViewLast();
        void RemoveFirst();
        void RemoveLast();
        void ShowAllElements();        
        void ClearList();
    }
}
