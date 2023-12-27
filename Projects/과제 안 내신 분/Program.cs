using System;
using System.Collections;
using System.Collections.Generic;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new();

            for (int i = 0; i < 28; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 1; i < 31; i++)
            {
                if (!list.Contains(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
