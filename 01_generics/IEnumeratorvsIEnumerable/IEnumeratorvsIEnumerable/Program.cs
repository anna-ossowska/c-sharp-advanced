using System;
using System.Collections;
using System.Collections.Generic;

// IEnumerator performs the iteration
// IEnumerable is a collection that is iterable

namespace IEnumeratorvsIEnumerable
{
    public class MyList<T> : IEnumerable<T>
    {
        T[] items = new T[5];
        int count;

        public void Add(T item)
        {
            if (count == items.Length)
            {
                Array.Resize(ref items, items.Length * 2);
            }
            else
            {
                items[count++] = item;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                // syntactic sugar
                yield return items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var myList = new MyList<int>() { 25, 43, 11, 34 };

            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
