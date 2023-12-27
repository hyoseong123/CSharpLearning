using System;
using System.Collections;
using System.Collections.Generic;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(" ");

            int ballCount = int.Parse(s[0]);
            int readCount = int.Parse(s[1]);

            int[] list = new int[ballCount];

            for (int i = 0; i < ballCount; i++)
            {
                list[i] = i + 1;
            }

            for (int i = 0; i < readCount; i++)
            {
                string[] st = Console.ReadLine().Split(" ");

                Stack<int> stack = new();

                for (int j = int.Parse(st[0]) - 1; j <= int.Parse(st[1]) - 1; j++)
                {
                    // 지정한 숫자부터 스택에 저장
                    stack.Push(list[j]);
                }

                for (int j = int.Parse(st[0]) - 1; j <= int.Parse(st[1]) - 1; j++)
                {
                    // 후입선출로 리스트에 저장
                    list[j] = stack.Pop();
                }
            }

            for (int i = 0; i < list.Length; i++)
            {
                Console.Write(list[i] + " ");
            }
        }
    }
}
