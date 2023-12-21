using System;
using System.Collections.Generic;

namespace Balloon_HHS
{
    class Program
    {
        static void Main(string[] args)
        {
            string timesTmp = Console.ReadLine();
            string setNumbersTmp = Console.ReadLine();

            int times = int.Parse(timesTmp);
            string[] arr = setNumbersTmp.Split(" ");

            int[] setNumbers = new int[times];

            int dequeTmp;

            for (int i = 0; i < arr.Length; i++)
            {
                setNumbers[i] = int.Parse(arr[i]);
            }

            Queue<int> que = new Queue<int>(setNumbers);

            dequeTmp = que.Dequeue();

            PrintIndex(setNumbers, dequeTmp);

            while (true)
            {
                if (que.Count == 0)
                {
                    return;
                }

                if (dequeTmp < 0)
                {
                    ReverseQueue(que);

                    for (int j = 1; j < Math.Abs(dequeTmp); j++)
                    {
                        que.Enqueue(que.Dequeue());
                    }

                    dequeTmp = que.Dequeue();

                    PrintIndex(setNumbers, dequeTmp);

                    ReverseQueue(que);

                    continue;
                }

                for (int j = 1; j < dequeTmp; j++)
                {
                    que.Enqueue(que.Dequeue());
                }

                dequeTmp = que.Dequeue();

                PrintIndex(setNumbers, dequeTmp);
            }
        }

        static Queue<int> ReverseQueue(Queue<int> que)
        {
            Stack<int> stack = new Stack<int>();

            int count = que.Count;

            for (int i = 0; i < count; i++)
            {
                stack.Push(que.Dequeue());
            }

            for (int i = 0; i < count; i++)
            {
                que.Enqueue(stack.Pop());
            }

            return que;
        }

        static void PrintIndex(int[] numbers, int goalNum)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == goalNum)
                {
                    Console.Write($"{i + 1} ");
                }
            }
        }
    }
}
