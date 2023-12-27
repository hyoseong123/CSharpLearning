using System;
using System.Collections;
using System.Collections.Generic;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            string[] stringScore = Console.ReadLine().Split(" ");

            List<decimal> score = new();

            for (int i = 0; i < count; i++)
            {
                score.Add(int.Parse(stringScore[i]));
            }

            score.Sort();

            decimal[] list = new decimal[count];

            for (int i = 0; i < count; i++)
            {
                list[i] = score[i] / score[count - 1] * 100;
            }

            decimal result = 0;

            for (int i = 0; i < score.Count; i++)
            {
                result += list[i];
            }

            Console.WriteLine(result / count);
        }
    }
}
