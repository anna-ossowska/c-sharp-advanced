using System;
using System.Collections.Generic;


namespace GenericMethods
{
    public class List<T>
    {
        public T[] list = new T[3];
        public int index;
        public int Length { get { return list.Length; } }

        // Generic method declared with the type parameter
        public void Add(T item)
        {
            if (index == list.Length)
            {
                Grow();
            }
            list[index++] = item;
        }

        // Generic method declared with the type parameter for its return type
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
        // Generic method declared outside of the generic class requires angle brackets <T> after its name
        static void PrintItems<T>(List<T> items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine(items.Get(i));
            }
        }

        static void Main(string[] args)
        {
            List<int> myListInt = new List<int>();
            myListInt.Add(1);
            myListInt.Add(2);
            myListInt.Add(3);
            myListInt.Add(4);

            PrintItems(myListInt);
    
            List<string> myListString = new List<string>();
            myListString.Add("Hello");
            myListString.Add("World");

            PrintItems(myListString);
        }
    }
}