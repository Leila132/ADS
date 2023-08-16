using System;
using System.Collections.Generic;

namespace Task4
{
    public class Stack<T>
    {
        public class Node<T>
        {
            public Node<T> next;
            public T value;
            public Node(T value)
            {
                this.value = value;
                next = null;
            }

        }
        private Node<T> up;
        private Node<T> down;
        private int count = 0;

        public T GetUp()
        {
            if (up == null)
            {
                return default(T);
            }
            else { return up.value; }
        }
        public T GetDown()
        {
            if (down == null)
            {
                return default(T);
            }
            else { return down.value; }
        }
        public int GetCount()
        {
            return count;
        }
        public void Print()
        {
            string values = "";
            Node<T> start = up;
            while (start != null)
            {
                values += start.value.ToString() + " ";
                start = start.next;
            }
            Console.WriteLine(values);
        }
        public void Push(T x)
        {
            Node<T> a = new Node<T>(x);
            if (count == 0)
            {
                up = a;
                down = a;
            }
            else
            {
                a.next = up;
                up = a;
            }
            count += 1;
        }
        public T Pop()
        {
            if (count != 0)
            {
                Node<T> rtrn = up;
                if (count == 1)
                {
                    up = null;
                    down = null;
                }
                else
                {
                    up = up.next;
                }
                count -= 1;
                return rtrn.value;
            }
            return default(T);
        }
    }
    class Program
    {
        public static int[,] Arr (List<int> list)
        {
            int[,] result = new int[list.Count, 2];
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < list.Count; i++)
            {
                result[i, 0] = list[i];
                result[i, 1] = -1;
                stack.Push(list[i]);
            }
            int N = list.Count;
            while(N > 0)
            {
                int current = stack.Pop();
                for (int i = 0; i < N-1; i++)
                {
                    if(current > list[i])
                    {
                        result[i, 1] = N - 1;
                    }
                }
                N--;
            }

            //Вывод массива
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < 2; j++)
                    Console.Write(String.Format("{0,3}", result[i, j]));
                Console.WriteLine();
            }
            return result;
        }
        static void Main(string[] args)
        {
            List<int> list = new List<int>(){ 4, 3, 7, 8, 2};
            int[,] a = Arr(list);
        }
    }
}
