using System;
using System.Collections.Generic;

// Showing how Generic Lists work under the hood

namespace GenericList
{
    public class MyList<T>
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
    }

    class Program
    {
        static void Main(string[] args)
        {
            var myList = new MyList<int>();
            myList.Add(12);
            myList.Add(11);
            myList.Add(35);
            myList.Add(10);
            myList.Add(98);
            myList.Add(102);
        }
    }
}
