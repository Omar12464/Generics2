using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics2
{
    internal class FixedSize<T>
    {
        private T[] items;
        private int count;

        public int Capacity { get; private set; }
        public int Count { get { return count; } }

        public FixedSizeList(int capacity)
        {
            if (capacity <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(capacity), "Capacity must be greater than zero.");
            }

            Capacity = capacity;
            items = new T[Capacity];
            count = 0;
        }

        public void Add(T item)
        {
            if (count >= Capacity)
            {
                throw new InvalidOperationException("List is already full.");
            }

            items[count] = item;
            count++;
        }

        public T Get(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Invalid index.");
            }

            return items[index];
        }
    }
}

