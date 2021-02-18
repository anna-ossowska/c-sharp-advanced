using System;
using System.Collections.Generic;

// IEnumerator performs the iteration

namespace IEnumerator
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

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                // syntactic sugar
                yield return items[i];
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

            // foreach under the hood:
            //IEnumerator<int> rator = myList.GetEnumerator();

            //while (rator.MoveNext())
            //{
            //    Console.WriteLine(rator.Current);
            //}

            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
