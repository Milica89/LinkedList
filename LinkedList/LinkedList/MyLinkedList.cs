using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class MyLinkedList<T> : IMyLinkedList<T>
    {
        public class Element
        {
            public T Value;
            public Element Next;
            public Element Previous;

        }

        public int Size { get; private set; }
        private Element FrontElement;
        private Element BackElement;
        private Element LastDeletedElement;


        public void AddToFront(T elementToAdd)
        {
            Size++;
            var newElement = new Element()
            {
                Value = elementToAdd
            };
            if (FrontElement == null)
            {
                FrontElement = newElement;
                BackElement = FrontElement;
            }
            else
            {
                FrontElement.Previous = newElement;
                newElement.Next = FrontElement;
                FrontElement = newElement;
            }
        }

        public void AddToBack(T elementToAdd)
        {
            Size++;
            var newElement = new Element()
            {
                Value = elementToAdd
            };
            if (BackElement == null)
            {
                BackElement = newElement;
                FrontElement = BackElement;
            }
            else
            {
                newElement.Previous = BackElement;
                BackElement.Next = newElement;
                BackElement = newElement;
            }
        }

        public T ViewFrontElement()
        {
            VerifyListNotEmpty();

            return this.FrontElement.Value;
        }

        public T ViewBackElement()
        {
            VerifyListNotEmpty();

            return this.BackElement.Value;
        }

        public Element RemoveFrontElement()
        {
            VerifyListNotEmpty();
            Size--;
            LastDeletedElement = FrontElement;
            FrontElement = FrontElement.Next;
            FrontElement.Previous = null;
            return LastDeletedElement;

        }

        public Element RemoveBackElement()
        {
            VerifyListNotEmpty();
            Size--;
            LastDeletedElement = BackElement;
            BackElement = BackElement.Previous;
            BackElement.Next = null;
            return LastDeletedElement;

        }

        public void ShowAllElements()
        {
            VerifyListNotEmpty();
            Element ElementToWrite = FrontElement;            
            while (ElementToWrite != BackElement.Next)
            {
                Console.WriteLine(ElementToWrite.Value);
                ElementToWrite = ElementToWrite.Next;
            }
            //Console.WriteLine(BackElement.Value);
        }

        public void ClearList()
        {
            BackElement = null;
            FrontElement = null;
            Size = 0;
        }

        private void VerifyListNotEmpty()
        {
            if (Size == 0)
                throw new InvalidOperationException("list is empty!");
        }
    }
}
