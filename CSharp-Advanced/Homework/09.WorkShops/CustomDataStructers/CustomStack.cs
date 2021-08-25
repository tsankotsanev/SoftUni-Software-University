using System;
using System.Collections;
using System.Collections.Generic;

namespace CustomDataStructers
{
    public class CustomStack<T> : IEnumerable<T>
    {
        private const int InitialCapacity = 4;
        private T[] items;

        public CustomStack()
        {
            items = new T[InitialCapacity];
            Count = 0;
        }

        public int Count { get; private set; }

        public void Push(T element)
        {
            if (items.Length == Count)
            {
                EnsureCapacity();
            }
            items[Count] = element;
            Count++;
        }
        public T Pop()
        {
            ThrowWhenEmpty();
            var lastIndex = items[Count - 1];
            Count--;
            return lastIndex;
        }
        public T Peek()
        {
            ThrowWhenEmpty();
            return items[Count - 1];
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

        private void ThrowWhenEmpty()
        {
            if (Count == 0)
            {
                throw new Exception("Stack is empty");
            }
        }
        public void ForEach(Action<T> action)
        {
            for (var i = Count - 1; i >= 0; i--)
            {
                action(items[i]);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (var i = Count-1; i >= 0; i--)
            {
                yield return items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return null;
        }
    }
}
