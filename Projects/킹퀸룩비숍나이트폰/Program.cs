using System;
using System.Collections.Generic;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(" ");
            int[] dap = { 1, 1, 2, 2, 2, 8 };

            for (int i = 0; i < 6; i++)
            {
                int t = 0;

                t = dap[i] - int.Parse(str[i]);

                Console.Write(t + " ");
            }
        }
    }
}
