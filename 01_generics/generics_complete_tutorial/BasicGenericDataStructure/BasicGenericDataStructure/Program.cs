using System;
using System.Collections.Generic;


namespace BasicGenericDataStructure
{
    public class List<T>
    {
        public T[] list = new T[3];
        public int index;
        public int Length { get { return list.Length; } }

        public void Add(T item)
        {
            if (index == list.Length)
            {
                Grow();
            }
            list[index++] = item;
        }

        public T Get(int index)
        {
            return list[index];
        }

        private void Grow()
        {
            T[] temp = new T[list.Length * 2];
            Array.Copy(list, temp, list.Length);
            list = temp;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            List<int> myListInt = new List<int>();
            myListInt.Add(1);
            myListInt.Add(2);
            myListInt.Add(3);
            myListInt.Add(4);

            for (int i = 0; i < myListInt.Length; i++)
            {
                Console.WriteLine(myListInt.Get(i));
            }

            List<string> myListString = new List<string>();
            myListString.Add("Hello");
            myListString.Add("World");

            for (int i = 0; i < myListString.Length; i++)
            {
                Console.WriteLine(myListString.Get(i));
            }
        }
    }
}
