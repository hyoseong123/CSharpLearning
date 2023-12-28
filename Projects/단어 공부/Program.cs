using System;
using System.Collections.Generic;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string st = Console.ReadLine();

            st = st.ToUpper();

            int[] ans = new int[91];

            for (int i = 0; i < st.Length; i++)
            {
                for (int j = 65; j < 91; j++)
                {
                    if (st[i] == Convert.ToChar(j))
                    {
                        ans[j]++;
                    }
                }
            }

            int max = 0;
            int maxIdx = 0;

            bool isSame = false;

            foreach (var item in ans)
            {
                if (item != 0 && item == max)
                {
                    isSame = true ;
                }

                if (item > max)
                {
                    max = item;
                    maxIdx = Array.IndexOf(ans, item);
                    isSame = false;
                }
            }

            if (isSame)
            {
                Console.WriteLine("?");
                return;
            }
              
            Console.WriteLine(Convert.ToChar(maxIdx));
        }
    }
}
