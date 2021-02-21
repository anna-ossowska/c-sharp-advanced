using System;
using System.Collections.Generic;


namespace BasicGenericDataStructure
{
    public class List
    {
        public int[] list = new int[3];
        public int index;
        public int Length { get { return list.Length; } }

        public void Add(int item)
        {
            if (index == list.Length)
            {
                Grow();
            }
            list[index++] = item;
        }

        public int Get(int index)
        {
            return list[index];
        }

        private void Grow()
        {
            int[] temp = new int[list.Length * 2];
            Array.Copy(list, temp, list.Length);
            list = temp;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var myList = new List();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);

            for (int i = 0; i < myList.Length; i++)
            {
                Console.WriteLine(myList.Get(i));
            }
        }
    }
}
