using System;
using System.Collections.Generic;

namespace Snail_HHS
{
    class Program
    {
        static void Main(string[] args)
        {
            string mapTemp = Console.ReadLine();

            int mapNum = int.Parse(mapTemp);

            int[,] map = new int[mapNum, mapNum];

            int[] moveX = { 0, 1, 0, -1 };
            int[] moveY = { 1, 0, -1, 0 };

            int mapXPoint = 0;
            int mapYPoint = 0;

            int count = 0;
            int moveNum = 0;

            map[0, 0] = ++count;

            while (count != mapNum * mapNum)
            {
                if (mapXPoint + moveX[moveNum] > mapNum - 1 || mapYPoint + moveY[moveNum] > mapNum - 1 || mapXPoint + moveX[moveNum] < 0 || mapYPoint + moveY[moveNum] < 0 || map[mapXPoint + moveX[moveNum], mapYPoint + moveY[moveNum]] != 0)
                {
                    moveNum++;

                    if (moveNum == 4)
                    {
                        moveNum = 0;
                    }
                }

                mapXPoint += moveX[moveNum];
                mapYPoint += moveY[moveNum];

                map[mapXPoint, mapYPoint] = ++count;
            }

            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    Console.Write($"{map[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
