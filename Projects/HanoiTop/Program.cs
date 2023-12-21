using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace HanoiTop_HHS
{
    class Program
    {
        private const int count = 5;
        private static int total = 0;

        private static Stack<int> start = new Stack<int>();
        private static Stack<int> to = new Stack<int>();
        private static Stack<int> end = new Stack<int>();

        static void Main(string[] args)
        {
            for (int i = count; i > 0 ; i--)
            {
                start.Push(i);
            }

            AllPrintHanoi();

            Hanoi(count, start, end, to);

            Console.WriteLine($"총 이동 횟수는 {total}번 입니다.");
        }

        private static void Hanoi(int n, Stack<int> startHanoi, Stack<int> endHanoi, Stack<int> toHanoi)
        {
            if(n == 1)
            {
                int top = startHanoi.Pop();

                endHanoi.Push(top);

                total++;

                AllPrintHanoi();
            }
            else
            {
                Hanoi(n - 1, startHanoi, toHanoi, endHanoi);

                int top = startHanoi.Pop();

                endHanoi.Push(top);

                total++;

                AllPrintHanoi();

                Hanoi(n - 1,toHanoi,endHanoi,startHanoi);
            }
        }
        
        private static void AllPrintHanoi()
        {
            PrintHanoi("A", start);
            PrintHanoi("B", to);
            PrintHanoi("C", end);

            Console.WriteLine();
        }

        private static void PrintHanoi(string type, Stack<int> stack)
        {
            Stack stacktmp = new Stack();

            foreach (var item in stack)
            {
                stacktmp.Push(item);
            }

            Console.Write(type + " : ");

            foreach (var item in stacktmp)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}
