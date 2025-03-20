class Node
{
    public int value;
    public Node? next;

    public Node(int value)
    {
        this.value = value;
        this.next = null;
    }
}

public class CircularSinglyLinkedList
{
    private Node? tail;
    private int size;
    private int CantidadSaltos;

    public CircularSinglyLinkedList()
    {
        this.tail = null;
        this.size = 0;
        this.CantidadSaltos = 0;
    }

    public bool isEmpty()
    {
        if (this.size == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool IncertarInicio(int value)
    {
        Node NuevoNodo = new Node(value);
        if (this.isEmpty())
        {
            this.tail = NuevoNodo;
            this.tail.next = this.tail;
        }
        else
        {
            NuevoNodo.next = this.tail.next;
            this.tail.next = NuevoNodo;
        }
        this.size++;
        return true;
    }

    public bool IncertarFinal(int value)
    {
        {
            Node NuevoNodo = new Node(value);
            if (isEmpty())
            {
                this.tail = NuevoNodo;
                this.tail.next = this.tail;
            }
            else
            {
                NuevoNodo.next = this.tail.next;
                this.tail.next = NuevoNodo;
                this.tail = NuevoNodo;
            }
            this.size++;
            return true;
        }
    }

    public bool InsertAt(int value, int indice)
    {
        if (indice > this.size)
        {
            return false;
        }
        else
        {
            if (indice == 0)
            {
                return this.IncertarInicio(value);
            }
            else if (indice == this.size)
            {
                return this.IncertarFinal(value);
            }
            else
            {
                Node NuevoNodo = new Node(value);
                Node NodoSiguiente = this.tail.next;
                for (int i = 0; i < indice - 1; i++)
                {
                    NodoSiguiente = NodoSiguiente.next;
                }
                NuevoNodo.next = NodoSiguiente.next;
                NodoSiguiente.next = NuevoNodo;
                this.size++;
                return true;
            }

        }
    }

    public bool EliminarInicio()
    {
        if (this.isEmpty())
        {
            return false;
        }
        else
        {
            if (this.size == 1)
            {
                this.tail = null;
            }
            else
            {
                this.tail.next = this.tail.next.next;
            }
            this.size--;
            return true;
        }
    }

    public bool EliminarFinal()
    {
        if (this.isEmpty())
        {
            return false;
        }
        else
        {
            if (this.size == 1)
            {
                this.tail = null;
            }
            else
            {
                Node NodoAnterior = this.tail.next;
                while (NodoAnterior.next != this.tail)
                {
                    NodoAnterior = NodoAnterior.next;
                }
                NodoAnterior.next = this.tail.next;
                this.tail = NodoAnterior;
            }
            this.size--;
            return true;
        }
    }

    public bool DeleteAt(int indice)
    {
        if (indice >= this.size)
        {
            return false;
        }
        else
        {
            if (indice == 0)
            {
                return this.EliminarInicio();
            }
            else if (indice == this.size - 1)
            {
                return this.EliminarFinal();
            }
            else
            {
                Node NodoAnterior = this.tail.next;
                for (int i = 0; i < indice - 1; i++)
                {
                    NodoAnterior = NodoAnterior.next;
                }
                NodoAnterior.next = NodoAnterior.next.next;
                this.size--;
                return true;
            }
        }
    }

    public int DarTamaño()
    {
        return this.size;
    }

    public void ToStirng()
    {
        if (this.isEmpty())
        {
            Console.WriteLine("La lista esta vacia");
        }
        else
        {
            Node NodoActual = this.tail.next;
            for (int i = 0; i < this.size; i++)
            {
                Console.Write(NodoActual.value + " , ");
                NodoActual = NodoActual.next;
            }
            Console.WriteLine();
        }
    }
}
class progam {
    static void Main()
    {

    }
}