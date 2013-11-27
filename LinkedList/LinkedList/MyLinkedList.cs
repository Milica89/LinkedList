using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class MyLinkedList<T> : IMyLinkedList<T>
    {
        private class Element
        {
            public T Value;
            public Element Next;
            public Element Previous;
            
        }

        public int Size;
        private Element FirstElement;
        private Element LastElement;
        

        public void AddFirst(T elementToAdd)
        {
            Size++;
            var newElement = new Element() 
            {
                Value = elementToAdd
            };
            if (FirstElement == null)
            {                
                FirstElement = newElement;
                LastElement = FirstElement;
            }
            else
            {
                FirstElement.Previous = newElement;
                newElement.Next = FirstElement;                
                FirstElement = newElement;
            }
        }

        public void AddLast(T elementToAdd)
        {
            Size++;
            var newElement = new Element()
            {
                Value = elementToAdd
            };
            if (LastElement == null)
            {                
                LastElement = newElement;
                FirstElement = LastElement;
            }
            else 
            {
                newElement.Previous = LastElement;
                LastElement.Next = newElement;
                LastElement = newElement;
            }
        }

        public T ViewFirst()
        {
            if (Size == 0)
            {
                throw new InvalidOperationException("list is empty!");
            }

            return this.FirstElement.Value; 
        }

        public T ViewLast()
        {
            if (Size == 0)
            {
                throw new InvalidOperationException("list is empty!");
            }

            return this.LastElement.Value;
        }

        public void RemoveFirst()
        {
            if (Size == 0)
            {
                throw new InvalidOperationException("list is empty!");
            }
            Size--;
            FirstElement = FirstElement.Next;
            FirstElement.Previous = null;
        }

        public void RemoveLast()
        {
            if (Size == 0)
            {
                throw new InvalidOperationException("list is empty!");
            }
            Size--;
            LastElement = LastElement.Previous;
            LastElement.Next = null;
        }

        public void ShowAllElements()
        {
            Element ElementToWrite = FirstElement;
            if (Size == 0)
            {
                Console.WriteLine("list is empty!");
            }
            while (ElementToWrite != null)
            {
                Console.WriteLine(ElementToWrite.Value);
                ElementToWrite = ElementToWrite.Next;
            }
        }

        public void ClearList()
        {
            LastElement = null;
            FirstElement = null;
            Size = 0;

            //Element ElementToRemove = FirstElement;
            //while (ElementToRemove != null)
            //{
            //    ElementToRemove = null;
            //    ElementToRemove = ElementToRemove.Next;
            //}
        }
    }
}
