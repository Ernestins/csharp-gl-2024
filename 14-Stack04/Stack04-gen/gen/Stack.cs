using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack.gen
{
    class Stack<T>
    {
        private T[] __data;
        private int __pos;

        public Stack(int size) => __data = new T[__pos = size];


        public T   push(T value) => __data[--__pos] = value;
        public T   pop() => __data[__pos++];
        public T   peek() => __data[__pos];

        public int capacity() => __data.Length;
        public int size() => __pos;

        public bool isEmpty() => __pos == 0;
        public bool isFull() => __pos == capacity();
    }
}
