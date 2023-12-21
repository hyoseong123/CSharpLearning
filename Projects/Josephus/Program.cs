using System;
using System.Collections;

namespace Josephus2_HHS
{
    class Program
    {
        static void Main(string[] args)
        {
            string arrStringTemp = Console.ReadLine();
            string[] circleAndSumNumArr = arrStringTemp.Split(" ");

            int circle = int.Parse(circleAndSumNumArr[0]);
            int sumNum = int.Parse(circleAndSumNumArr[1]);

            int[] quetmp = new int[circle];

            for (int i = 1; i <= circle; i++)
            {
                quetmp[i - 1] = i;
            }

            Queue queue = new Queue(quetmp);

            while (true)
            {
                if (queue.Count == 0)
                {
                    return;
                }

                for (int i = 1; i < sumNum; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }

                Console.Write($"{queue.Dequeue()} ");
            }
        }
    }
}
