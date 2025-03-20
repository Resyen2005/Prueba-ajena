namespace TestProject1
{
    [TestClass]
    public class CircularDoublyLinkedListTests
    {
        [TestMethod]
        public void IsEmpty_NewList_ReturnsTrue()
        {
            CircularDoublyLinkedList list = new CircularDoublyLinkedList();
            Assert.IsTrue(list.IsEmpty());
        }

        [TestMethod]
        public void InsertarInicio_OneElement_ListIsNotEmpty()
        {
            CircularDoublyLinkedList list = new CircularDoublyLinkedList();
            list.InsertarInicio(10);
            Assert.IsFalse(list.IsEmpty());
            Assert.AreEqual("10", list.ToString());
        }

        [TestMethod]
        public void InsertarInicio_MultipleElements_CorrectOrder()
        {
            CircularDoublyLinkedList list = new CircularDoublyLinkedList();
            list.InsertarInicio(30);
            list.InsertarInicio(20);
            list.InsertarInicio(10);
            Assert.AreEqual("10, 20, 30", list.ToString());
        }

        [TestMethod]
        public void InsertarFinal_OneElement_ListIsNotEmpty()
        {
            CircularDoublyLinkedList list = new CircularDoublyLinkedList();
            list.InsertarFinal(10);
            Assert.IsFalse(list.IsEmpty());
            Assert.AreEqual("10", list.ToString());
        }

        [TestMethod]
        public void InsertarFinal_MultipleElements_CorrectOrder()
        {
            CircularDoublyLinkedList list = new CircularDoublyLinkedList();
            list.InsertarFinal(10);
            list.InsertarFinal(20);
            list.InsertarFinal(30);
            Assert.AreEqual("10, 20, 30", list.ToString());
        }

        [TestMethod]
        public void InsertAt_Beginning_CorrectOrder()
        {
            CircularDoublyLinkedList list = new CircularDoublyLinkedList();
            list.InsertarFinal(20);
            list.InsertAt(10, 0);
            Assert.AreEqual("10, 20", list.ToString());
        }

        [TestMethod]
        public void InsertAt_End_CorrectOrder()
        {
            CircularDoublyLinkedList list = new CircularDoublyLinkedList();
            list.InsertarFinal(10);
            list.InsertAt(20, 1);
            Assert.AreEqual("10, 20", list.ToString());
        }

        [TestMethod]
        public void InsertAt_Middle_CorrectOrder()
        {
            CircularDoublyLinkedList list = new CircularDoublyLinkedList();
            list.InsertarFinal(10);
            list.InsertarFinal(30);
            list.InsertAt(20, 1);
            Assert.AreEqual("10, 20, 30", list.ToString());
        }

        [TestMethod]
        public void InsertAt_IndexOutOfRange_ThrowsException()
        {
            CircularDoublyLinkedList list = new CircularDoublyLinkedList();
            Assert.ThrowsException<IndexOutOfRangeException>(() => list.InsertAt(10, 1));
        }

        [TestMethod]
        public void EliminarInicio_OneElement_ListIsEmpty()
        {
            CircularDoublyLinkedList list = new CircularDoublyLinkedList();
            list.InsertarInicio(10);
            list.EliminarInicio();
            Assert.IsTrue(list.IsEmpty());
        }

        [TestMethod]
        public void EliminarInicio_MultipleElements_CorrectOrder()
        {
            CircularDoublyLinkedList list = new CircularDoublyLinkedList();
            list.InsertarInicio(30);
            list.InsertarInicio(20);
            list.InsertarInicio(10);
            list.EliminarInicio();
            Assert.AreEqual("20, 30", list.ToString());
        }

        [TestMethod]
        public void EliminarInicio_EmptyList_ThrowsException()
        {
            CircularDoublyLinkedList list = new CircularDoublyLinkedList();
            Assert.ThrowsException<InvalidOperationException>(() => list.EliminarInicio());
        }

        [TestMethod]
        public void EliminarFinal_OneElement_ListIsEmpty()
        {
            CircularDoublyLinkedList list = new CircularDoublyLinkedList();
            list.InsertarFinal(10);
            list.EliminarFinal();
            Assert.IsTrue(list.IsEmpty());
        }

        [TestMethod]
        public void EliminarFinal_MultipleElements_CorrectOrder()
        {
            CircularDoublyLinkedList list = new CircularDoublyLinkedList();
            list.InsertarFinal(10);
            list.InsertarFinal(20);
            list.InsertarFinal(30);
            list.EliminarFinal();
            Assert.AreEqual("10, 20", list.ToString());
        }

        [TestMethod]
        public void EliminarFinal_EmptyList_ThrowsException()
        {
            CircularDoublyLinkedList list = new CircularDoublyLinkedList();
            Assert.ThrowsException<InvalidOperationException>(() => list.EliminarFinal());
        }

        [TestMethod]
        public void EliminarAt_Beginning_CorrectOrder()
        {
            CircularDoublyLinkedList list = new CircularDoublyLinkedList();
            list.InsertarFinal(10);
            list.InsertarFinal(20);
            list.EliminarAt(0);
            Assert.AreEqual("20", list.ToString());
        }

        [TestMethod]
        public void EliminarAt_End_CorrectOrder()
        {
            CircularDoublyLinkedList list = new CircularDoublyLinkedList();
            list.InsertarFinal(10);
            list.InsertarFinal(20);
            list.EliminarAt(1);
            Assert.AreEqual("10", list.ToString());
        }

        [TestMethod]
        public void EliminarAt_Middle_CorrectOrder()
        {
            CircularDoublyLinkedList list = new CircularDoublyLinkedList();
            list.InsertarFinal(10);
            list.InsertarFinal(20);
            list.InsertarFinal(30);
            list.EliminarAt(1);
            Assert.AreEqual("10, 30", list.ToString());
        }

        [TestMethod]
        public void EliminarAt_IndexOutOfRange_ThrowsException()
        {
            CircularDoublyLinkedList list = new CircularDoublyLinkedList();
            Assert.ThrowsException<IndexOutOfRangeException>(() => list.EliminarAt(1));
        }

        [TestMethod]
        public void ObtenerTamaño_EmptyList_ReturnsZero()
        {
            CircularDoublyLinkedList list = new CircularDoublyLinkedList();
            Assert.AreEqual(0, list.ObtenerTamaño());
        }

        [TestMethod]
        public void ObtenerTamaño_MultipleElements_ReturnsCorrectSize()
        {
            CircularDoublyLinkedList list = new CircularDoublyLinkedList();
            list.InsertarFinal(10);
            list.InsertarFinal(20);
            Assert.AreEqual(2, list.ObtenerTamaño());
        }
    }
}
