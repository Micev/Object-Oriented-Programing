using System;
using System.Text;

[Version(1,10)]
class GenericList<T> where T : IComparable<T>
{
    const int DefaultCapacity = 16;

    private T[] elements;
    private int count;

    public GenericList(int capacity = DefaultCapacity)
    {
        elements = new T[capacity];
        this.Count = 0;
    }
    public int Count
    {
        get
        {
            return this.count;
        }
        private set
        {
            this.count = value;
        }
    }
    public int Capacity
    {
        get
        {
            return this.elements.Length;
        }

    }

    public void Add(T element)
    {
        if (this.Count >= elements.Length)
        {
            T[] buffer = new T[this.Capacity * 2];
            for (int i = 0; i < elements.Length; i++)
            {
                buffer[i] = elements[i];
            }
            this.elements = buffer;
        }
        this.elements[this.Count] = element;
        this.Count++;
    }
    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= this.Count)
            {
                throw new IndexOutOfRangeException("Wrong index!!!");
            }
            return elements[index];
        }
    }
    public void Remove(int index)
    {
        if ((index < 0) || (index >= this.Count))
        {
            throw new IndexOutOfRangeException("Wrong Index!!!");
        }
        T[] buffer = new T[this.Capacity - 1];
        int counter = 0;
        for (int i = 0; i < elements.Length; i++)
        {
            if (i == index)
            {
                counter--;
            }
            else
            {
                buffer[counter] = elements[i];
            }

            counter++;
        }
        this.elements = buffer;
        this.Count--;
    }
    public void Insert(int index, T element)
    {
        if (index < 0 || index > elements.Length) throw new IndexOutOfRangeException("Wrong Index");
        T[] buffer = new T[this.Capacity + 1];
        for (int i = 0, position = 0; i < elements.Length - 1; position++)
        {
            // If the position in the buffer has reached the one we are looking for, write the value.
            // Else, copy the array element by element
            if (position == index)
            {
                buffer[position] = element;
                continue;
            }
            else
            {
                buffer[position] = this.elements[i];
                i++;
            }
        }

        this.elements = buffer;
        this.Count++;

    }

    public void Clear()
    {
        T[] buffer = new T[this.Capacity];
        this.elements = buffer;
        this.Count = 0;
    }

    public int Find(T element)
    {
        for (int i = 0; i < this.count; i++)
        {
            if (this.elements[i].Equals(element))
            {
                return i;
            }
        }

        return -1;  
    }

    public bool Contains(T element)
    {
        if (this.Find(element) != -1)
        {
            return true;
        }

        return false;
    }
    public override string ToString()
    {
        StringBuilder result = new StringBuilder(this.count);
        for (int i = 0; i < this.count; i++)
        {
            result.Append(this.elements[i] + ", ");
        }
        return result.ToString().Trim(' ', ',');
    }

    public T Max()
    {
        if (count < 1) throw new ArgumentNullException("List is empty!!!");
        T max = elements[0];
        for (int i = 0; i < this.Count; i++)
        {
            if (this.elements[i].CompareTo(max) > 0)
            {
                max = elements[i];
            }
        }
        return max;
    }

    public T Min()
    {
        if (count < 1) throw new ArgumentNullException("List is empty!!!");
        T min = elements[0];
        for (int i = 0; i < this.Count; i++)
        {
            if (this.elements[i].CompareTo(min) < 0)
            {
                min = elements[i];
            }
        }
        return min;
    }
}


