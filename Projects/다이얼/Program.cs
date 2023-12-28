using System;
using System.Collections.Generic;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            int res = 0;

            for (int i = 0; i < str.Length; i++)
            {
                char ch = Convert.ToChar(str.Substring(i, 1));

                if(ch >= 'A' && ch <= 'C')
                {
                    res += 3;
                }
                else if (ch >= 'D' && ch <= 'F')
                {
                    res += 4;
                }
                else if (ch >= 'G' && ch <= 'I')
                {
                    res += 5;
                }
                else if (ch >= 'J' && ch <= 'L')
                {
                    res += 6;
                }
                else if (ch >= 'M' && ch <= 'O')
                {
                    res += 7;
                }
                else if (ch >= 'P' && ch <= 'S')
                {
                    res += 8;
                }
                else if (ch >= 'T' && ch <= 'V')
                {
                    res += 9;
                }
                else if (ch >= 'W' && ch <= 'Z')
                {
                    res += 10;
                }
            }

            Console.WriteLine(res);
        }
    }
}
