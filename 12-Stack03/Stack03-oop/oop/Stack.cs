using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack.oop
{
    class Stack<T>
    {
        private T[]   __data;
        private int   __pos;

        public Stack(int capacity)  => __data = new T[__pos = capacity];
       

        public T    push(T value)   => __data[--__pos] = value;
        public T    pop ()          => __data[__pos++];
        public T    peek()          => __data[__pos];

        public int  capacity() => __data.Length;
        public int  size()     => __pos;

        public bool isEmpty() => __pos == capacity();
        public bool isFull()  => capacity()-__pos == 0;
    }
}
