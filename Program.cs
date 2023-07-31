using System;

namespace DinArray
{
    class DArray
    {
        int[] intArray;
        int n;
        
        private int[] Reallocate(int[]a, bool r) ///true - увеличение, false - уменьшение
        {
            if (r)
            {
                int[] newAr = new int[a.Length * 2];
                for (int i = 0; i < a.Length; i++)
                {
                    newAr[i] = a[i];
                }
                return newAr;
            }
            else
            {
                int[] newAr = new int[a.Length / 2];
                for (int i = 0; i < a.Length; i++)
                {
                    if(a[i] != 0) newAr[i] = a[i];
                }
                return newAr;
            }
        }

        public string print()
        {
            string str = "[";
            for (int i = 0; i < intArray.Length; i++)
            {
                str += intArray[i];
            }
            str += "]";
            return str;
        }
        public int count()
        {
            return n;
        }
        public DArray(int[] a, int b) //создаем конструктор
        {
            intArray = new int[a.Length*2];
            for(int i = 0; i < a.Length; i++)
            {
                intArray[i] = a[i];
            }
            n = b;
        }

        public void Push_Back(int el)
        {
            if (n != 0)
            {
                if (intArray[intArray.Length - 1] != 0)
                {
                    intArray = Reallocate(intArray, true);
                    intArray[intArray.Length / 2] = el;
                }
                else
                {
                    intArray[n] = el;
                }
            }
            else
            {
                intArray = new int[1] { el };
            }
            n++;
        }
        public void Pop_Back()
        {
            if (n > 0)
            {
                intArray[n - 1] = 0;
                if (intArray[intArray.Length / 2] == 0)
                {
                    intArray = Reallocate(intArray, false);
                }
                n--;
            }
        }
        public void Push_Front(int el)
        {
            int[] newAr;
            if (n != 0)
            {
                if (intArray[intArray.Length - 1] != 0)
                {
                    intArray = Reallocate(intArray, true);
                }
                newAr = new int[intArray.Length];
                newAr[0] = el;
                for (int i = 1; i < n + 1; i++)
                {
                    newAr[i] = intArray[i - 1];
                }
            }
            else
            {
                newAr = new int[1] { el };
            }
            intArray = newAr;
            n++;
        }
        public void Pop_Front()
        {
            if (n > 0)
            {
                int[] newAr = new int[intArray.Length];
                for(int i = 1; i < n; i++)
                {
                    newAr[i-1] = intArray[i];
                }
                intArray = newAr;
                if (intArray[intArray.Length / 2] == 0)
                {
                    intArray = Reallocate(intArray, false);
                }
                n--;
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
            Console.WriteLine(ar.print());
            Console.WriteLine(ar.count());
            ar.Push_Back(3);
            Console.WriteLine(ar.print());
            Console.WriteLine(ar.count());
            ar.Push_Back(4);
            Console.WriteLine(ar.print());
            Console.WriteLine(ar.count());
            ar.Push_Back(5);
            Console.WriteLine(ar.print());
            Console.WriteLine(ar.count());
            ar.Push_Back(6);
            Console.WriteLine(ar.print());
            Console.WriteLine(ar.count());
            ar.Pop_Back();
            Console.WriteLine(ar.print());
            Console.WriteLine(ar.count());
            ar.Pop_Back();
            Console.WriteLine(ar.print());
            Console.WriteLine(ar.count());
            ar.Pop_Back();
            Console.WriteLine(ar.print());
            Console.WriteLine(ar.count());
            ar.Pop_Back();
            Console.WriteLine(ar.print());
            Console.WriteLine(ar.count());
            ar.Pop_Back();
            Console.WriteLine(ar.print());
            Console.WriteLine(ar.count());
            ar.Pop_Back();
            Console.WriteLine(ar.print());
            Console.WriteLine(ar.count());
            ar.Pop_Back();
            Console.WriteLine(ar.print());
            Console.WriteLine(ar.count());
            Console.WriteLine("*******************************************");
            ar.Push_Back(4);
            Console.WriteLine(ar.print());
            Console.WriteLine(ar.count());
            ar.Push_Front(5);
            Console.WriteLine(ar.print());
            Console.WriteLine(ar.count());
            ar.Push_Front(6);
            Console.WriteLine(ar.print());
            Console.WriteLine(ar.count());
            ar.Push_Front(7);
            Console.WriteLine(ar.print());
            Console.WriteLine(ar.count());
            ar.Push_Front(8);
            Console.WriteLine(ar.print());
            Console.WriteLine(ar.count());
            ar.Pop_Front();
            Console.WriteLine(ar.print());
            Console.WriteLine(ar.count());
            ar.Pop_Front();
            Console.WriteLine(ar.print());
            Console.WriteLine(ar.count());
            ar.Pop_Front();
            Console.WriteLine(ar.print());
            Console.WriteLine(ar.count());
            ar.Pop_Front();
            Console.WriteLine(ar.print());
            Console.WriteLine(ar.count());
            ar.Pop_Front();
            Console.WriteLine(ar.print());
            Console.WriteLine(ar.count());
            ar.Pop_Front();
            Console.WriteLine(ar.print());
            Console.WriteLine(ar.count());
        }
    }
}
