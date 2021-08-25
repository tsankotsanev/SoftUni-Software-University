using System;
using System.Text;

namespace CustomDataStructers
{
    public class CustomList<T>
    {
        private const int InitialCapacity = 2;
        private T[] items;
        public CustomList()
        {
            items = new T[InitialCapacity];
            Count = 0;
        }

        public int Count { get; private set; }

        public T this[int index]
        {
            get
            {
                ValidIndex(index);
                return items[index];
            }
            set
            {
                ValidIndex(index);
                items[index] = value;
            }
        }
        public void Add(T item)
        {

            if (Count == items.Length)
            {
                EnsureCapacity();
            }
            items[Count] = item;
            Count++;
        }

        public T RemoveAt(int index)
        {
            ValidIndex(index);
            var element = items[index];
            ShiftLeft(index);
            Count--;
            Shrink();
            return element;
        }
        public void InsertAt(int index, T element)
        {
            ValidIndex(index);
            EnsureCapacity();
            Count++;
            ShiftRight(index);
            items[index] = element;

        }
        public T Find(Predicate<T> match)
        {
            foreach (var item in items)
            {
                if (match(item))
                {
                    return item;
                }
            }

            return default;
        }
        private void EnsureCapacity()
        {
            if (items.Length > Count)
            {
                return;
            }
            var copy = new T[items.Length * 2];

            for (var i = 0; i < items.Length; i++)
            {
                copy[i] = items[i];
            }
            items = copy;
        }
        public void Reverse()
        {
            for (var i = 0; i < Count / 2; i++)
            {
                Swap(i, Count - i - 1);
            }
        }
        public void Swap(int firstIndex, int secondIndex)
        {
            ValidIndex(firstIndex);
            ValidIndex(secondIndex);
            (items[firstIndex], items[secondIndex]) = (items[secondIndex], items[firstIndex]);
        }
        private void ValidIndex(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new IndexOutOfRangeException();
            }

        }
        private void Shrink()
        {
            if (Count * 4 >= items.Length)
            {
                return;
            }
            var tempArray = new T[items.Length / 2];

            for (var i = 0; i < Count; i++)
            {
                tempArray[i] = items[i];
            }
            items = tempArray;
        }
        private void ShiftLeft(int index)
        {
            for (var i = 0; i < Count-1; i++)
            {
                items[i] = items[i + 1];
            }
            items[Count - 1] = default;
        }
        private void ShiftRight(int index)
        {
            for (var i = Count; i > index; i--)
            {
                items[i] = items[i - 1];
            }
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            for (var i = 0; i < Count - 1; i++)
            {
                sb.Append($"{items[i]}, ");
            }

            return sb.ToString().TrimEnd(' ', ',');
        }

    }
}
