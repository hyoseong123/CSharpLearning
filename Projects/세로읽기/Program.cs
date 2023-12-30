using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] secint = new string[5, 15];

            for (int i = 0; i < 5; i++)
            {
                string st = Console.ReadLine();

                for (int j = 0; j < st.Length; j++)
                {
                    secint[i, j] = st.Substring(j, 1);
                }
            }

            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (secint[j, i] == null)
                    {
                        continue;
                    }

                    Console.Write(secint[j, i]);
                }
            }
        }
    }
}

