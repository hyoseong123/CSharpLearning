using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeGrow_HHS
{
    class Tree
    {
        public Tree(int _indexX, int _indexY, int _age)
        {
            indexX = _indexX;
            indexY = _indexY;
            age = _age;
        }

        public int indexX { get; set; }

        public int indexY { get; set; }

        public int age { get; set; }

        public void growTree()
        {
            age++;
        }

        public int[,] eatNutriment(int[,] map)
        {
            map[indexX, indexY] -= age;

            return map;
        }

        public List<Tree> addBabyTree(int[,] map, List<Tree> trees)
        {
            int[] moveX = { -1, -1, -1, 0, 1, 1, 1, 0 };
            int[] moveY = { -1, 0, 1, 1, 1, 0, -1, -1 };

            for (int i = 0; i < 8; i++)
            {
                if (indexX + moveX[i] > map.GetLength(0) || indexX + moveX[i] == 0 || indexY + moveY[i] > map.GetLength(1) || indexY + moveY[i] == 0)
                {
                    continue;
                }

                trees.Add(new Tree(indexX + moveX[i], indexY + moveY[i], 1));
            }

            return trees;
        }

        public int[,] beTheNutriment(int[,] map)
        {
            map[indexX, indexY] += age / 2;

            return map;
        }
    }
}
