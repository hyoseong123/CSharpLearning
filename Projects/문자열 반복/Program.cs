using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int cnt = int.Parse(Console.ReadLine());

            for (int i = 0; i < cnt; i++)
            {
                StringBuilder sb = new();
                
                string[] str = Console.ReadLine().Split(" ");

                int t = int.Parse(str[0]);
                string st = str[1];

                for (int j = 0; j < st.Length; j++)
                {
                    for (int k = 0; k < t; k++)
                    {
                        sb.Append(st.Substring(j, 1));
                    }
                }

                Console.WriteLine(sb.ToString());
            }
        }
    }
}
