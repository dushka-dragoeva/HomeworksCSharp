namespace _06_07.Generic
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class GenericList<T> where T : IComparable, new()
    {
        const int capacityGenericList = 32;

        private T[] elements;
        private int count = 0;
        private int capacity;

        public GenericList(int capacity)
        {
            this.elements = new T[capacity];
            this.Capacity = capacity;
        }
        public int Capacity
        {
            get { return this.capacity; }
            private set { this.capacity = value; }
        }

        public GenericList()
            : this(capacityGenericList)
        {
        }
        public int Count
        {
            get { return this.count; }
        }
        public void Add(T element)
        {
            if (count >= elements.Length)
            {
                this.DoubleSize();
            }
            this.elements[count] = element;
            count++;
        }

        public T this[int index]
        {
            get
            {
                if (index >= count || index < 0)
                {
                    throw new IndexOutOfRangeException
                        (String.Format("Invalid index: {0}.", index));
                }
                T result = elements[index];
                return result;
            }
        }
        public T RemoveElement(int index)
        {
            if (index >= count)
            {
                throw new IndexOutOfRangeException
                    (string.Format("Invalid index {0} ", index));
            }
            T result = elements[index];
            for (int i = index; i < count - 1; i++)
            {
                this.elements[i] = this.elements[i + 1];
            }
            this.elements[count - 1] = new T();
            count--;
            return result;

        }
        public void InsertElement(int index, T element)
        {
            if (index > count || index < 0)
            {
                throw new IndexOutOfRangeException(String.Format(
                    "Invalid index: {0}.", index));
            }
            if (index == count)
            {
                this.Add(element);
                return;
            }
            if (count >= this.elements.Length - 1)
            {
                this.DoubleSize();
            }
            count++;
            for (int i = count; i > index; i--)
            {
                this.elements[i] = this.elements[i - 1];
            }

            this.elements[index] = element;

        }
        public void ClearList()
        {
            this.elements = new T[capacityGenericList];
            this.count = 0;
            this.Capacity = capacityGenericList;
        }
        public int IndexOf(T element)
        {
            for (int i = 0; i < count; i++)
            {
                if (this.elements[i].Equals(element))
                {
                    return i;
                }
            }

            return -1;
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                result.Append(elements[i]);
                if (i < count - 1)
                {
                    result.Append(", ");
                }
            }
            return result.ToString();
        }
        public void DoubleSize()
        {
            int newSize = this.elements.Length * 2;
            T[] newArr = new T[newSize];
            for (int i = 0; i < count; i++)
            {
                newArr[i] = this.elements[i];
            }
            this.elements = newArr;
            this.Capacity *= 2;
        }

        public T Min()
        {
            T min = this.elements[0];

            for (int i = 0; i < count; i++)
            {
                if (this.elements[i].CompareTo(min) < 0)
                {
                    min = this.elements[i];
                }
            }
            return min;
        }
        public T Max()
        {
            T max = this.elements[0];

            for (int i = 0; i < count; i++)
            {
                if (this.elements[i].CompareTo(max) > 0)
                {
                    max = this.elements[i];
                }
            }
            return max;
        }
    }
}
