namespace TestProject1;

[TestClass]
public class CircularSinglyLinkedListTests
{
    [TestMethod]
    public void isEmpty_NewList_ReturnsTrue()
    {
        CircularSinglyLinkedList list = new CircularSinglyLinkedList();
        Assert.IsTrue(list.isEmpty());
    }

    [TestMethod]
    public void IncertarInicio_OneElement_ListIsNotEmpty()
    {
        CircularSinglyLinkedList list = new CircularSinglyLinkedList();
        Assert.IsTrue(list.IncertarInicio(10));
        Assert.IsFalse(list.isEmpty());
        Assert.AreEqual(1, list.DarTamaño());
    }

    [TestMethod]
    public void IncertarInicio_MultipleElements_CorrectSize()
    {
        CircularSinglyLinkedList list = new CircularSinglyLinkedList();
        Assert.IsTrue(list.IncertarInicio(30));
        Assert.IsTrue(list.IncertarInicio(20));
        Assert.IsTrue(list.IncertarInicio(10));
        Assert.AreEqual(3, list.DarTamaño());
    }

    [TestMethod]
    public void IncertarFinal_OneElement_ListIsNotEmpty()
    {
        CircularSinglyLinkedList list = new CircularSinglyLinkedList();
        Assert.IsTrue(list.IncertarFinal(10));
        Assert.IsFalse(list.isEmpty());
        Assert.AreEqual(1, list.DarTamaño());
    }

    [TestMethod]
    public void IncertarFinal_MultipleElements_CorrectSize()
    {
        CircularSinglyLinkedList list = new CircularSinglyLinkedList();
        Assert.IsTrue(list.IncertarFinal(10));
        Assert.IsTrue(list.IncertarFinal(20));
        Assert.IsTrue(list.IncertarFinal(30));
        Assert.AreEqual(3, list.DarTamaño());
    }

    [TestMethod]
    public void InsertAt_Beginning_CorrectSize()
    {
        CircularSinglyLinkedList list = new CircularSinglyLinkedList();
        Assert.IsTrue(list.IncertarFinal(20));
        Assert.IsTrue(list.InsertAt(10, 0));
        Assert.AreEqual(2, list.DarTamaño());
    }

    [TestMethod]
    public void InsertAt_End_CorrectSize()
    {
        CircularSinglyLinkedList list = new CircularSinglyLinkedList();
        Assert.IsTrue(list.IncertarFinal(10));
        Assert.IsTrue(list.InsertAt(20, 1));
        Assert.AreEqual(2, list.DarTamaño());
    }

    [TestMethod]
    public void InsertAt_Middle_CorrectSize()
    {
        CircularSinglyLinkedList list = new CircularSinglyLinkedList();
        Assert.IsTrue(list.IncertarFinal(10));
        Assert.IsTrue(list.IncertarFinal(30));
        Assert.IsTrue(list.InsertAt(20, 1));
        Assert.AreEqual(3, list.DarTamaño());
    }

    [TestMethod]
    public void InsertAt_IndexOutOfRange_ReturnsFalse()
    {
        CircularSinglyLinkedList list = new CircularSinglyLinkedList();
        Assert.IsFalse(list.InsertAt(10, 1));
    }

    [TestMethod]
    public void EliminarInicio_OneElement_ListIsEmpty()
    {
        CircularSinglyLinkedList list = new CircularSinglyLinkedList();
        Assert.IsTrue(list.IncertarInicio(10));
        Assert.IsTrue(list.EliminarInicio());
        Assert.IsTrue(list.isEmpty());
    }

    [TestMethod]
    public void EliminarInicio_MultipleElements_CorrectSize()
    {
        CircularSinglyLinkedList list = new CircularSinglyLinkedList();
        Assert.IsTrue(list.IncertarInicio(30));
        Assert.IsTrue(list.IncertarInicio(20));
        Assert.IsTrue(list.IncertarInicio(10));
        Assert.IsTrue(list.EliminarInicio());
        Assert.AreEqual(2, list.DarTamaño());
    }

    [TestMethod]
    public void EliminarInicio_EmptyList_ReturnsFalse()
    {
        CircularSinglyLinkedList list = new CircularSinglyLinkedList();
        Assert.IsFalse(list.EliminarInicio());
    }

    [TestMethod]
    public void EliminarFinal_OneElement_ListIsEmpty()
    {
        CircularSinglyLinkedList list = new CircularSinglyLinkedList();
        Assert.IsTrue(list.IncertarFinal(10));
        Assert.IsTrue(list.EliminarFinal());
        Assert.IsTrue(list.isEmpty());
    }

    [TestMethod]
    public void EliminarFinal_MultipleElements_CorrectSize()
    {
        CircularSinglyLinkedList list = new CircularSinglyLinkedList();
        Assert.IsTrue(list.IncertarFinal(10));
        Assert.IsTrue(list.IncertarFinal(20));
        Assert.IsTrue(list.IncertarFinal(30));
        Assert.IsTrue(list.EliminarFinal());
        Assert.AreEqual(2, list.DarTamaño());
    }

    [TestMethod]
    public void EliminarFinal_EmptyList_ReturnsFalse()
    {
        CircularSinglyLinkedList list = new CircularSinglyLinkedList();
        Assert.IsFalse(list.EliminarFinal());
    }

    [TestMethod]
    public void DeleteAt_Beginning_CorrectSize()
    {
        CircularSinglyLinkedList list = new CircularSinglyLinkedList();
        Assert.IsTrue(list.IncertarFinal(10));
        Assert.IsTrue(list.IncertarFinal(20));
        Assert.IsTrue(list.DeleteAt(0));
        Assert.AreEqual(1, list.DarTamaño());
    }

    [TestMethod]
    public void DeleteAt_End_CorrectSize()
    {
        CircularSinglyLinkedList list = new CircularSinglyLinkedList();
        Assert.IsTrue(list.IncertarFinal(10));
        Assert.IsTrue(list.IncertarFinal(20));
        Assert.IsTrue(list.DeleteAt(1));
        Assert.AreEqual(1, list.DarTamaño());
    }

    [TestMethod]
    public void DeleteAt_Middle_CorrectSize()
    {
        CircularSinglyLinkedList list = new CircularSinglyLinkedList();
        Assert.IsTrue(list.IncertarFinal(10));
        Assert.IsTrue(list.IncertarFinal(20));
        Assert.IsTrue(list.IncertarFinal(30));
        Assert.IsTrue(list.DeleteAt(1));
        Assert.AreEqual(2, list.DarTamaño());
    }

    [TestMethod]
    public void DeleteAt_IndexOutOfRange_ReturnsFalse()
    {
        CircularSinglyLinkedList list = new CircularSinglyLinkedList();
        Assert.IsFalse(list.DeleteAt(1));
    }

    [TestMethod]
    public void DarTamaño_EmptyList_ReturnsZero()
    {
        CircularSinglyLinkedList list = new CircularSinglyLinkedList();
        Assert.AreEqual(0, list.DarTamaño());
    }

    [TestMethod]
    public void DarTamaño_MultipleElements_ReturnsCorrectSize()
    {
        CircularSinglyLinkedList list = new CircularSinglyLinkedList();
        Assert.IsTrue(list.IncertarFinal(10));
        Assert.IsTrue(list.IncertarFinal(20));
        Assert.AreEqual(2, list.DarTamaño());
    }

    [TestMethod]
    public void ToString_EmptyList_PrintsEmptyMessage()
    {
        using (var sw = new StringWriter())
        {
            Console.SetOut(sw);
            CircularSinglyLinkedList list = new CircularSinglyLinkedList();
            list.ToStirng();
            Assert.AreEqual("La lista esta vacia\r\n", sw.ToString());
        }
    }

    [TestMethod]
    public void ToString_MultipleElements_PrintsCorrectValues()
    {
        using (var sw = new StringWriter())
        {
            Console.SetOut(sw);
            CircularSinglyLinkedList list = new CircularSinglyLinkedList();
            list.IncertarFinal(10);
            list.IncertarFinal(20);
            list.IncertarFinal(30);
            list.ToStirng();
            Assert.AreEqual("10 , 20 , 30 , \r\n", sw.ToString());
        }
    }
}