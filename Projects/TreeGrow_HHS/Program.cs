using System;
using System.Collections.Generic;
using System.Linq;

namespace TreeGrow_HHS
{
    class Program
    {
        // n : 칸 수, m : 나무 수, k : 지날 년 수
        static int n;
        static int m;
        static int k;

        // x, y : 나무의 좌표, z : 나무 나이
        static int x;
        static int y;
        static int z;

        static string[] nutrimentArr;

        public static int[,] map;

        public static List<Tree> trees = new();
        public static List<Tree> dieTrees = new();


        static void Main(string[] args)
        {
            // nmk 입력받기
            string nmkTmp = Console.ReadLine();

            string[] nmkTmpArr = nmkTmp.Split(" ");

            n = int.Parse(nmkTmpArr[0]);
            m = int.Parse(nmkTmpArr[1]);
            k = int.Parse(nmkTmpArr[2]);

            n++;

            map = new int[n, n];

            // 양분 입력받기
            for (int i = 1; i < map.GetLength(0); i++)
            {
                string nutrimentTmp = Console.ReadLine();
                nutrimentArr = nutrimentTmp.Split(" ");
                
                for (int j = 1; j < map.GetLength(1); j++)
                {
                    map[i, j] = 5;
                }
            }

            // 나무 정보 입력받기
            for (int i = 0; i < m; i++)
            {
                string ageAndIndexXYTmp = Console.ReadLine();
                string[] ageAndIndexXYArr = ageAndIndexXYTmp.Split(" ");

                x = int.Parse(ageAndIndexXYArr[0]);
                y = int.Parse(ageAndIndexXYArr[1]);
                z = int.Parse(ageAndIndexXYArr[2]);

                trees.Add(new Tree(x,y,z));
            }

            // 사계절 시작

            int yearCount = 0;

            while (yearCount != k)
            {
                // 오름차 정렬
                List<Tree> treesTmp = trees.OrderBy(x => x.age).ToList();
                trees = new List<Tree>(treesTmp);

                Spring();

                Summer();

                Fall();

                Winter();

                yearCount++;
            }

            Console.WriteLine(trees.Count);
        }

        static void Spring()
        {
            for (int i = 0; i < trees.Count; i++)
            {
                if (map[trees[i].indexX, trees[i].indexY] < trees[i].age)
                {
                    dieTrees.Add(trees[i]);
                    trees.Remove(trees[i]);

                    i--;

                    continue;
                }

                trees[i].eatNutriment(map);
                trees[i].growTree();
            }
        }

        static void Summer()
        {
            for (int i = 0; i < dieTrees.Count; i++)
            {
                dieTrees[i].beTheNutriment(map);
            }

            dieTrees.Clear();
        }

        static void Fall()
        {
            for (int i = 0; i < trees.Count; i++)
            {
                if (trees[i].age % 5 == 0)
                {
                    trees[i].addBabyTree(map, trees);
                }
            }
        }

        static void Winter()
        {
            for (int i = 1; i < map.GetLength(0); i++)
            {
                for (int j = 1; j < map.GetLength(1); j++)
                {
                    map[i, j] += int.Parse(nutrimentArr[j - 1]);
                }
            }
        }
    }
}
