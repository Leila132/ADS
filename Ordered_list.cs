using System;
using System.Collections.Generic;

namespace OrderedList
{
    class Program
    {
        public class OrderedList
        {
            private int count = 0;
            private List<int> ListElems = new List<int>();

            public int GetCount()
            {
                return count;
            }
            public string Print()
            {
                string print = "[";
                for (int i = 0; i < ListElems.Count; i++)
                {
                    if (i != ListElems.Count - 1)
                    {
                        print += ListElems[i] + ", ";
                    }
                    else 
                    {
                        print += ListElems[i]; 
                    }
                }
                print += "]";
                return print;
            }
            public double Begin()
            {
                if (count > 0)
                {
                    return ListElems[0];
                }
                else
                {
                    return double.NegativeInfinity;
                }
            }
            public double End()
            {
                if (count > 0)
                {
                    return ListElems[ListElems.Count - 1];
                }
                else
                {
                    return double.NegativeInfinity;
                }
            }
            public void Insert(int el)
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
                        bool IsInsert = false;
                        for (int i = 0; i < ListElems.Count; i++)
                        {

                            if (ListElems[i] < el)
                            {
                                ListElems2.Add(ListElems[i]);
                            }
                            else
                            {
                                if (IsInsert)
                                {
                                    ListElems2.Add(ListElems[i]);
                                }
                                else
                                {
                                    ListElems2.Add(el);
                                    ListElems2.Add(ListElems[i]);
                                    IsInsert = false;
                                }
                            }
                        }
                        if (ListElems2.Count == ListElems.Count)
                        {
                            ListElems2.Add(el);
                        }
                    }
                    ListElems = ListElems2;
                }
                count++;
            }
            public void Remove(int el)
            {
                List<int> ListElems2 = new List<int>();
                bool IsRemoved = false;
                for (int i = 0; i < ListElems.Count; i++)
                {
                    if (ListElems[i] != el) ListElems2.Add(ListElems[i]);
                    else
                    {
                        if (IsRemoved)
                        {
                            ListElems2.Add(ListElems[i]);
                        }
                        else
                        {
                            IsRemoved = true;
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
            a.Insert(3);
            Console.WriteLine(a.Print());
            Console.WriteLine(a.GetCount());
            a.Insert(4);
            Console.WriteLine(a.Print());
            Console.WriteLine(a.GetCount());
            a.Insert(5);
            Console.WriteLine(a.Print());
            Console.WriteLine(a.GetCount());
            a.Insert(4);
            Console.WriteLine(a.Print());
            Console.WriteLine(a.GetCount());
            a.Insert(3);
            Console.WriteLine(a.Print());
            Console.WriteLine(a.GetCount());
            a.Insert(2);
            Console.WriteLine(a.Print());
            Console.WriteLine(a.GetCount());
            a.Remove(5);
            Console.WriteLine(a.Print());
            Console.WriteLine(a.GetCount());
            a.Remove(2);
            Console.WriteLine(a.Print());
            Console.WriteLine(a.GetCount());
        }
    }
}
