
using System.Runtime.Serialization;

namespace SortedList
{
    /*
    class SpeziList<T, K> where T : ICloneable, IComparable 
                          where K : ISerializable
    {

    }
    */

    class Data : IComparable, ICloneable
    {
        public Data()
        {
            
        }
        public Data(int c)
        {
            
        }
        public object Clone()
        {
            throw new NotImplementedException();
        }

        public int CompareTo(object? obj)
        {
            throw new NotImplementedException();
        }
    }

    class SortedList<T> where T : IComparable, ICloneable, new()
    {
        T[] arr =  new T[100];

        public void Add(T item)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int result = ((IComparable)item).CompareTo(arr[i]);
            }
        }
    }
}
