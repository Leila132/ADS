using System;

namespace Stack
{
    public class Stack
    {
        public class Node
        {
            public Node next;
            public int value;
            public Node(int value)
            {
                this.value = value;
                next = null;
            }

        }
        private Node up;
        private Node down;
        private int count = 0;

        public int GetUp()
        {
            if (up == null)
            {
                return default(int);
            }
            else { return up.value; }
        }
        public int GetDown()
        {
            if (down == null)
            {
                return default(int);
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
            Node start = up;
            while (start != null)
            {
                values += start.value.ToString() + " ";
                start = start.next;
            }
            Console.WriteLine(values);
        }
        public void Push(int x)
        {
            Node a = new Node(x);
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
        public int Pop()
        {
            if (count != 0)
            {
                Node rtrn = up;
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
            return default(int);
        }
    }
    class Program
    {
        public static Stack SelectionSort(Stack old) //O(n^2)
        {
            Stack helper = new Stack();
            int N = old.GetCount();
            while (N > 0)
            {
                int max = int.MinValue;
                for (int i = 0; i < N; i++)
                {
                    int current = old.Pop();
                    helper.Push(current);
                    if (current > max)
                    {
                        max = current;
                    }
                }
                old.Push(max);
                bool IsMaxRemoved = false;
                for (int i = 0; i < N; i++)
                {
                    int current = helper.Pop();
                    if(current != max)
                    {
                        old.Push(current);
                    }
                    else
                    {
                        if (IsMaxRemoved)
                        {
                            old.Push(current);
                        }
                        else
                        {
                            IsMaxRemoved = true;
                        }
                    }
                }
                N--;
            }
            return old;            
        }
        static void Main(string[] args)
        {
            Stack a = new Stack();
            a.Push(1);
            a.Push(3);
            a.Push(1);
            a.Push(5);
            a.Print();
            Stack b = SelectionSort(a);
            b.Print();
        }
    }
}
