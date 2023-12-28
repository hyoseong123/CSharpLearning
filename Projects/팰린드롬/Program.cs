using System;
using System.Collections.Generic;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string st = Console.ReadLine();

            Stack<string> stk = new();

            for (int i = 0; i < st.Length; i++)
            {
                stk.Push(st.Substring(i, 1));
            }

            StringBuilder sb = new();

            for (int i = 0; i < st.Length; i++)
            {
                sb.Append(stk.Pop());
            }

            if (st == sb.ToString())
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
