using System;
using System.Linq;

namespace MergeSortAr
{
    class Program
    {
        static int[] Merge (int[] a, int[] b)
        {
            int[] result = new int[a.Length + b.Length];
            int a_it = 0;
            int b_it = 0;
            int res_it = 0;
            while(a_it != a.Length && b_it != b.Length)
            {
                if(a[a_it] <= b[b_it])
                {
                    result[res_it] = a[a_it];
                    a_it++;
                }
                else
                {
                    result[res_it] = b[b_it];
                    b_it++;
                }
                res_it++;
            }
            while(a_it != a.Length)
            {
                result[res_it] = a[a_it];
                a_it++;
                res_it++;
            }
            while (b_it != b.Length)
            {
                result[res_it] = b[b_it];
                b_it++;
                res_it++;
            }
            return result;
        }
        static int[] MergeSort(int[] a)
        {
            if (a.Length == 1)
            {
                return a;
            }
            if (a.Length == 2)
            {
                if (a[1] > a[0])
                {
                    return a;
                }
                else
                {
                    int c = a[0];
                    a[0] = a[1];
                    a[1] = c;
                    return a;
                }
            }
            else
            {
                int mid;
                if (a.Length % 2 == 0)
                {
                    mid = a.Length / 2;
                }
                else
                {
                    mid = (a.Length + 1) / 2;
                }
                int[] a1 = a.Take(mid).ToArray();
                int[] a2 = a.Skip(mid).ToArray();
                return Merge(MergeSort(a1), MergeSort(a2));
            }
        }
        static void Main(string[] args)
        {
            int[] a = new int[6] { 12, 20, 5, 5, 1, 17 };
            int[] c = MergeSort(a);
            Console.WriteLine(String.Join(", ", c));
        }
    }
}
