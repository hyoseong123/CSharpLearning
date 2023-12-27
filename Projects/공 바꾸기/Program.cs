using System;

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

                int temp = list[int.Parse(st[0]) - 1];

                list[int.Parse(st[0]) - 1] = list[int.Parse(st[1]) - 1];
                list[int.Parse(st[1]) - 1] = temp;
            }

            for (int i = 0; i < list.Length; i++)
            {
                Console.Write(list[i] + " ");
            }
        }
    }
}
