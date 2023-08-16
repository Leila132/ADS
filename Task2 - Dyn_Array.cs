using System;

namespace DinArray
{
    class DArray
    {
        private int[] intArray;
        private int size;
        private int capacity;

        public DArray(int[] a, int b) //создаем конструктор
        {
            intArray = new int[a.Length * 2];
            for (int i = 0; i < a.Length; i++)
            {
                intArray[i] = a[i];
            }
            size = b;
            capacity = b * 2;
        }
        private int[] Reallocate(int[]a, int b) ///массив и каким должен стать capacity
        {
            int[] newAr = new int[b];
            for (int i = 0; i < size; i++)
            {
                newAr[i] = a[i];
            }
            capacity = b;
            return newAr;
        }

        public string Print()
        {
            string str = "[";
            for (int i = 0; i < intArray.Length; i++)
            {
                str += intArray[i];
            }
            str += "]";
            return str;
        }
        public int Count()
        {
            return size;
        }
        public int Capacity()
        {
            return capacity;
        }
        public void Push_Back(int el) //3 монетки: 1 за вставку элемента, 2 другие за реаллокацию этого и соседнего элемента
        {
            if (size != 0)
            {
                if (size == capacity)
                {
                    intArray = Reallocate(intArray, capacity * 2);
                    intArray[size] = el;
                }
                else
                {
                    intArray[size] = el;
                }
            }
            else
            {
                intArray = new int[4];
                intArray[0] = el;
                capacity = 4;
            }
            size++;
        }
        public void Pop_Back() //2 монетки: 1 для удаления элемента, 1 для реаллокации соседнего
        {
            if (size > 0)
            {
                intArray[size - 1] = 0;
                if (capacity / size >= 4)
                {
                    intArray = Reallocate(intArray, capacity / 2);
                }
                size--;
            }
        }
        public void Push_Front(int el) //3 монетки: 1 за вставку элемента, 2 другие за реаллокацию этого и соседнего элемента
        {
            int[] newAr;
            if (size != 0)
            {
                if (size == capacity)
                {
                    intArray = Reallocate(intArray, capacity * 2);
                }
                newAr = new int[intArray.Length];
                newAr[0] = el;
                for (int i = 1; i < size + 1; i++)
                {
                    newAr[i] = intArray[i - 1];
                }
            }
            else
            {
                newAr = new int[4];
                newAr[0] = el;
                capacity = 4;
            }
            intArray = newAr;
            size++;
        }
        public void Pop_Front() //2 монетки: 1 для удаления элемента, 1 для реаллокации соседнего
        {
            if (size > 0)
            {
                int[] newAr = new int[intArray.Length];
                for(int i = 1; i < size; i++)
                {
                    newAr[i-1] = intArray[i];
                }
                intArray = newAr;
                if (capacity / size >= 4)
                {
                    intArray = Reallocate(intArray, capacity/2);
                }
                size--;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int N = 2;
            int[] a = new int[2] { 1, 2 };
            DArray ar = new DArray(a, N);
            Console.WriteLine(ar.Print());
            Console.WriteLine(ar.Count());
            Console.WriteLine(ar.Capacity());
            ar.Push_Back(3);
            Console.WriteLine(ar.Print());
            Console.WriteLine(ar.Count());
            Console.WriteLine(ar.Capacity());
            ar.Push_Back(4);
            Console.WriteLine(ar.Print());
            Console.WriteLine(ar.Count());
            Console.WriteLine(ar.Capacity());
            ar.Push_Back(5);
            Console.WriteLine(ar.Print());
            Console.WriteLine(ar.Count());
            Console.WriteLine(ar.Capacity());
            ar.Push_Back(6);
            Console.WriteLine(ar.Print());
            Console.WriteLine(ar.Count());
            Console.WriteLine(ar.Capacity());
            
            ar.Pop_Back();
            Console.WriteLine(ar.Print());
            Console.WriteLine(ar.Count());
            Console.WriteLine(ar.Capacity());
            ar.Pop_Back();
            Console.WriteLine(ar.Print());
            Console.WriteLine(ar.Count());
            Console.WriteLine(ar.Capacity());
            ar.Pop_Back();
            Console.WriteLine(ar.Print());
            Console.WriteLine(ar.Count());
            Console.WriteLine(ar.Capacity());
            ar.Pop_Back();
            Console.WriteLine(ar.Print());
            Console.WriteLine(ar.Count());
            Console.WriteLine(ar.Capacity());
            ar.Pop_Back();
            Console.WriteLine(ar.Print());
            Console.WriteLine(ar.Count());
            Console.WriteLine(ar.Capacity());
            ar.Pop_Back();
            Console.WriteLine(ar.Print());
            Console.WriteLine(ar.Count());
            Console.WriteLine(ar.Capacity());
            ar.Pop_Back();
            Console.WriteLine(ar.Print());
            Console.WriteLine(ar.Count());
            Console.WriteLine("*******************************************");
            ar.Push_Back(4);
            Console.WriteLine(ar.Print());
            Console.WriteLine(ar.Count());
            Console.WriteLine(ar.Capacity());
            ar.Push_Front(5);
            Console.WriteLine(ar.Print());
            Console.WriteLine(ar.Count());
            Console.WriteLine(ar.Capacity());
            ar.Push_Front(6);
            Console.WriteLine(ar.Print());
            Console.WriteLine(ar.Count());
            Console.WriteLine(ar.Capacity());
            ar.Push_Front(7);
            Console.WriteLine(ar.Print());
            Console.WriteLine(ar.Count());
            Console.WriteLine(ar.Capacity());
            ar.Push_Front(8);
            Console.WriteLine(ar.Print());
            Console.WriteLine(ar.Count());
            Console.WriteLine(ar.Capacity());
            ar.Pop_Front();
            Console.WriteLine(ar.Print());
            Console.WriteLine(ar.Count());
            Console.WriteLine(ar.Capacity());
            ar.Pop_Front();
            Console.WriteLine(ar.Print());
            Console.WriteLine(ar.Count());
            Console.WriteLine(ar.Capacity());
            ar.Pop_Front();
            Console.WriteLine(ar.Print());
            Console.WriteLine(ar.Count());
            Console.WriteLine(ar.Capacity());
            ar.Pop_Front();
            Console.WriteLine(ar.Print());
            Console.WriteLine(ar.Count());
            Console.WriteLine(ar.Capacity());
            ar.Pop_Front();
            Console.WriteLine(ar.Print());
            Console.WriteLine(ar.Count());
            Console.WriteLine(ar.Capacity());
            ar.Pop_Front();
            Console.WriteLine(ar.Print());
            Console.WriteLine(ar.Count());
            Console.WriteLine(ar.Capacity());

        }
    }
}
