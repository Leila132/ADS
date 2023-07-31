using System;
using System.Collections.Generic;

namespace OrderedList
{
    class Program
    {
        public class OrderedList
        {
            private int count = 0;
            List<int> ListElems = new List<int>();

            public int getCount()
            {
                return count;
            }
            public string print()
            {
                string print = "[";
                for (int i = 0; i < ListElems.Count; i++)
                { 
                    if(i != ListElems.Count - 1) print += ListElems[i] + ", ";
                    else print += ListElems[i]; 
                }
                print += "]";
                return print;
            }
            public double begin()
            {
                if (count > 0) return ListElems[0];
                else return double.NegativeInfinity;
            }
            public double end()
            {
                if (count > 0) return ListElems[ListElems.Count - 1];
                else return double.NegativeInfinity;
            }
            public void insert(int el)
            {
                if(count == 0)
                {
                    ListElems.Add(el);
                }
                else
                {
                    List<int> ListElems2 = new List<int>();
                    if (el < ListElems[0])
                    {
                        ListElems2.Add(el);
                        for (int i = 0; i < ListElems.Count; i++)
                        {
                            ListElems2.Add(ListElems[i]);
                        }
                    }
                    else
                    {
                        bool flag = true;
                        for (int i = 0; i < ListElems.Count; i++)
                        {

                            if (ListElems[i] < el) ListElems2.Add(ListElems[i]);
                            else
                            {
                                if (flag) { ListElems2.Add(el);ListElems2.Add(ListElems[i]); flag = false; }
                                else ListElems2.Add(ListElems[i]);
                            }
                        }
                        if (ListElems2.Count == ListElems.Count) ListElems2.Add(el);
                    }
                    ListElems = ListElems2;
                }
                count++;
            }
            public void remove(int el)
            {
                List<int> ListElems2 = new List<int>();
                bool flag = true;
                for (int i = 0; i < ListElems.Count; i++)
                {
                    if (ListElems[i] != el) ListElems2.Add(ListElems[i]);
                    else
                    {
                        if (flag)
                        {
                            flag = false;
                        }
                        else
                        {
                            ListElems2.Add(ListElems[i]);
                        }
                    }
                }
                ListElems = ListElems2;
                count--;
            }
        }

        static void Main(string[] args)
        {
            OrderedList a = new OrderedList();
            a.insert(3);
            Console.WriteLine(a.print());
            Console.WriteLine(a.getCount());
            a.insert(4);
            Console.WriteLine(a.print());
            Console.WriteLine(a.getCount());
            a.insert(5);
            Console.WriteLine(a.print());
            Console.WriteLine(a.getCount());
            a.insert(4);
            Console.WriteLine(a.print());
            Console.WriteLine(a.getCount());
            a.insert(3);
            Console.WriteLine(a.print());
            Console.WriteLine(a.getCount());
            a.insert(2);
            Console.WriteLine(a.print());
            Console.WriteLine(a.getCount());
            a.remove(5);
            Console.WriteLine(a.print());
            Console.WriteLine(a.getCount());
            a.remove(2);
            Console.WriteLine(a.print());
            Console.WriteLine(a.getCount());
        }
    }
}
