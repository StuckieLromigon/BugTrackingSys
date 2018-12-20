using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericLesson
{
    class FixedStack<T>
    {
        private T[] _items;

        public FixedStack(int size)
        {
            _items = new T[size];
        }

        public FixedStack() : this(10)
        {
        }

        public bool IsEmpty() { return _items[0].Equals(default(T));  }
        public int Count { get; private set; }
        public void Push(T t)
        {
            if (Count == _items.Length)
            {
                throw new StackOverflowException();
            }
            _items[Count] = t;
            Count++;
        }
        public T Peek()
        {
            if (IsEmpty()) throw new Exception("Stack is Empty!");
            return _items[Count - 1];
        }
        public T Pop()
        {
            T pop = Peek();
            _items[Count - 1] = default(T);
            Count--;
            return pop;

        }
    }
}
