class Nodos
{
    public int value;
    public Nodos? next;
    public Nodos? prev;

    public Nodos(int value)
    {
        this.value = value;
        this.next = null;
        this.prev = null;
    }
}

public class CircularDoublyLinkedList
{
    private Nodos? tail;
    private int size;

    public CircularDoublyLinkedList()
    {
        this.tail = null;
        this.size = 0;
    }

    public bool IsEmpty()
    {
        return size == 0;
    }

    public void InsertarInicio(int value)
    {
        Nodos nuevoNodo = new Nodos(value);
        if (IsEmpty())
        {
            this.tail = nuevoNodo;
            this.tail.next = tail;
            this.tail.prev = nuevoNodo; // Corregido: Cambiar "Nue" a "nuevoNodo".
        }
        else
        {
            nuevoNodo.next = tail.next;
            nuevoNodo.prev = tail;
            tail.next.prev = nuevoNodo;
            tail.next = nuevoNodo;
        }
        size++;
    }

    public void InsertarFinal(int value)
    {
        Nodos nuevoNodo = new Nodos(value);
        if (IsEmpty())
        {
            tail = nuevoNodo;
            tail.next = tail;
            tail.prev = tail;
        }
        else
        {
            nuevoNodo.next = tail.next;
            nuevoNodo.prev = tail;
            tail.next.prev = nuevoNodo;
            tail.next = nuevoNodo;
            tail = nuevoNodo;
        }
        size++;
    }

    public void InsertAt(int value, int indice)
    {
        if (indice < 0 || indice > size)
        {
            throw new IndexOutOfRangeException("Índice fuera de rango.");
        }

        if (indice == 0)
        {
            InsertarInicio(value);
        }
        else if (indice == size)
        {
            InsertarFinal(value);
        }
        else
        {
            Nodos nuevoNodo = new Nodos(value);
            Nodos actual = tail.next;
            for (int i = 0; i < indice - 1; i++)
            {
                actual = actual.next;
            }
            nuevoNodo.next = actual.next;
            nuevoNodo.prev = actual;
            actual.next.prev = nuevoNodo;
            actual.next = nuevoNodo;
            size++;
        }
    }

    public void EliminarInicio()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("La lista está vacía.");
        }

        if (size == 1)
        {
            tail = null;
        }
        else
        {
            Nodos head = tail.next;
            tail.next = head.next;
            head.next.prev = tail;
        }
        size--;
    }

    public void EliminarFinal()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("La lista está vacía.");
        }

        if (size == 1)
        {
            tail = null;
        }
        else
        {
            Nodos nuevoTail = tail.prev;
            nuevoTail.next = tail.next;
            tail.next.prev = nuevoTail;
            tail = nuevoTail;
        }
        size--;
    }

    public void EliminarAt(int indice)
    {
        if (indice < 0 || indice >= size)
        {
            throw new IndexOutOfRangeException("Índice fuera de rango.");
        }

        if (indice == 0)
        {
            EliminarInicio();
        }
        else if (indice == size - 1)
        {
            EliminarFinal();
        }
        else
        {
            Nodos actual = tail.next;
            for (int i = 0; i < indice; i++)
            {
                actual = actual.next;
            }
            actual.prev.next = actual.next;
            actual.next.prev = actual.prev;
            size--;
        }
    }

    public int ObtenerTamaño()
    {
        return size;
    }

    public override string ToString()
    {
        if (IsEmpty())
        {
            return "Lista vacía";
        }

        string resultado = "";
        Nodos actual = tail.next;
        do
        {
            resultado += actual.value + ", ";
            actual = actual.next;
        } while (actual != tail.next);

        return resultado.TrimEnd(',', ' ');
    }
}
class progam
{
    static void Main()
    {

    }
}