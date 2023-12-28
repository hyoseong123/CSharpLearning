using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(" ");

            Stack<string> stk = new();

            for (int i = 0; i < str[0].Length; i++)
            {
                stk.Push(str[0].Substring(i, 1));
            }

            StringBuilder sb = new();

            for (int i = 0; i < str[0].Length; i++)
            {
                sb.Append(stk.Pop());
            }

            int fn = int.Parse(sb.ToString());

            for (int i = 0; i < str[1].Length; i++)
            {
                stk.Push(str[1].Substring(i, 1));
            }

            sb = new();

            for (int i = 0; i < str[1].Length; i++)
            {
                sb.Append(stk.Pop());
            }

            int sn = int.Parse(sb.ToString());

            if (fn > sn)
            {
                Console.WriteLine(fn);
            }
            else
            {
                Console.WriteLine(sn);
            }
        }
    }
}
