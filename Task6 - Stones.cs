using System;
using System.Collections.Generic;

namespace Task6
{
    class Program
    {
        static int Stones(List<int> stones)
        {
            while(stones.Count > 1)
            {
                int top1 = int.MinValue;
                int top2 = int.MinValue;
                for(int i = 0; i < stones.Count; i++)
                {
                    if(stones[i] > top1)
                    {
                        top1 = stones[i];
                    }
                }
                stones.Remove(top1);
                for (int i = 0; i < stones.Count; i++)
                {
                    if (stones[i] > top2)
                    {
                        top2 = stones[i];
                    }
                }
                stones.Remove(top2);
                stones.Add(Math.Abs(top1 - top2));
            }
            return stones[0];
        }
        static void Main(string[] args)
        {
            List<int> stones = new List<int> { 5, 2, 9, 10, 16, 4, 4 };
            int result = Stones(stones);
            Console.WriteLine(result);
        }
    }
}
