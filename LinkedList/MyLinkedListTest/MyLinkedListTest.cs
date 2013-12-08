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
            int expectedSize = 1;
            MyLinkedList<int> list = new MyLinkedList<int>();

            //act
            list.AddToFront(firstElement);

            //assert
            Assert.AreEqual(list.Size, expectedSize);
        }

        [TestMethod]
        public void AddToBack_sizeChanging()
        {
            //arrange
            int Element = 5;
            int expectedSize = 1;
            MyLinkedList<int> list = new MyLinkedList<int>();

            //act
            list.AddToBack(Element);

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
        public void 

        [TestMethod]
        public void AddToFront_whenListIsNotEmpty()
        {
            //arrange
            int firstElement = 3;
            int secondElement = 5;
            int expectedSize = 2;
            MyLinkedList<int> list = new MyLinkedList<int>();

            //act
            list.AddToFront(firstElement);
            list.AddToFront(secondElement);

            //assert
            Assert.AreEqual(list.Size, expectedSize);
        }

        [TestMethod]
        public void AddToBack_whenListIsNotEmpty()
        {
            //arrange
            int firstElement = 3;
            int secondElement = 5;
            MyLinkedList<int> list = new MyLinkedList<int>();

            //act
            list.AddToBack(firstElement);
            list.AddToBack(secondElement);

            //assert
            Assert.AreEqual(firstElement, list.ViewFrontElement());
            Assert.AreEqual(secondElement, list.ViewBackElement());
        }
    }
}
