using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedList;

namespace MyLinkedListTest
{
    

    [TestClass]
    public class MyLinkedListTest
    {
        [TestMethod]
        public void AddToFront_sizeChanging()
        {
            //arrange
            int firstElement = 5;
            int secondElement = 7;
            int thirdElement = 6;
            int expectedSize = 3;
            MyLinkedList<int> list = new MyLinkedList<int>();

            //act
            list.AddToFront(firstElement);
            list.AddToFront(secondElement);
            list.AddToFront(thirdElement);

            //assert
            Assert.AreEqual(list.Size, expectedSize);
        }

        [TestMethod]
        public void AddToBack_sizeChanging()
        {
            //arrange
            int firstElement = 5;
            int secondElement = 7;
            int thirdElement = 6;
            int expectedSize = 3;
            MyLinkedList<int> list = new MyLinkedList<int>();

            //act
            list.AddToFront(firstElement);
            list.AddToFront(secondElement);
            list.AddToFront(thirdElement);

            //assert
            Assert.AreEqual(list.Size, expectedSize);            
        }

        [TestMethod]
        public void ViewFrontElement_whenListIsNotEmpty()
        {
            //arrange
            int element = 5;
            MyLinkedList<int> list=new MyLinkedList<int>();

            //act
            list.AddToFront(element);

            //assert
            Assert.AreEqual(list.ViewFrontElement(), element);
        }

        [TestMethod]
        public void ViewBackElement_whenListIsNotEmpty()
        {
            //arrange
            int element = 5;
            MyLinkedList<int> list = new MyLinkedList<int>();

            //act
            list.AddToBack(element);

            //assert
            Assert.AreEqual(list.ViewBackElement(), element);
        }

        [TestMethod]
        public void AddToFront_addingFirstElement()
        {
            //arrange
            int element = 5;
            MyLinkedList<int> list=new MyLinkedList<int>();

            //act
            list.AddToFront(element);

            //assert
            Assert.AreEqual(list.ViewFrontElement(), list.ViewBackElement());
        }

        [TestMethod]
        public void AddToBack_addingFirstElement()
        {
            //arrange
            int element = 5;
            MyLinkedList<int> list = new MyLinkedList<int>();

            //act
            list.AddToBack(element);

            //assert
            Assert.AreEqual(list.ViewFrontElement(), list.ViewBackElement());
        }

        [TestMethod]
        public void AddToFront_checkingOrderOfAdding()
        {
            //arrange
            int firstElement = 4;
            int secondElement = 5;
            int thirdElement = 6;
            MyLinkedList<int> list = new MyLinkedList<int>();

            //act
            list.AddToFront(firstElement);
            list.AddToFront(secondElement);
            list.AddToFront(thirdElement);

            //assert
            Assert.AreEqual(list.ViewFrontElement(), thirdElement);
            Assert.AreEqual(list.ViewBackElement(), firstElement);
        }

        [TestMethod]
        public void AddToBack_checkingOrderOfAdding()
        {
            //arrange
            int firstElement = 4;
            int secondElement = 5;
            int thirdElement = 6;
            MyLinkedList<int> list = new MyLinkedList<int>();

            //act
            list.AddToBack(firstElement);
            list.AddToBack(secondElement);
            list.AddToBack(thirdElement);

            //assert
            Assert.AreEqual(list.ViewFrontElement(), firstElement);
            Assert.AreEqual(list.ViewBackElement(), thirdElement);
        }

        [TestMethod]
        public void RemoveFrontElement_whenListIsNotEmpty()
        {
            //arrange
            int firstElement = 4;
            int secondElement = 5;
            int thirdElement = 6;
            MyLinkedList<int> list = new MyLinkedList<int>();
            list.AddToFront(firstElement);
            list.AddToFront(secondElement);
            list.AddToFront(thirdElement);

            //act
            MyLinkedList<int>.Element removedElement = list.RemoveFrontElement();

            //assert
            Assert.AreEqual(removedElement.Value, thirdElement);
        }

        [TestMethod]
        public void RemoveBackElement_whenListIsNotEmpty()
        {
            //arrange
            int firstElement = 4;
            int secondElement = 5;
            int thirdElement = 6;
            MyLinkedList<int> list = new MyLinkedList<int>();
            list.AddToFront(firstElement);
            list.AddToFront(secondElement);
            list.AddToFront(thirdElement);

            //act
            MyLinkedList<int>.Element removedElement = list.RemoveBackElement();

            //assert
            Assert.AreEqual(removedElement.Value, firstElement);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void throwingAnExceptionWhenListIsEmpty()
        {
            //arrange
            MyLinkedList<int> list = new MyLinkedList<int>();

            //act
            list.ViewFrontElement();
        }
    }
}
