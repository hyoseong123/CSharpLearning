using System;

namespace BalanceWorld_HHS
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentenceTmp = Console.ReadLine();
            char[] sentence = sentenceTmp.ToCharArray();

            int smallTurn = 0;
            int bigTurn = 0;
            int smallBracket = 0;
            int bigBracket = 0;

            foreach (var item in sentence)
            {
                if(item == '(')
                {
                    smallBracket++;
                    smallTurn++;
                }

                if (item == ')' && smallTurn == 0)
                {
                    Console.WriteLine("No");
                    return;
                }

                if (item == ')')
                {
                    smallBracket--;
                }

                if (item == '[')
                {
                    bigBracket++;
                    bigTurn++;
                }

                if (item == ']' && bigTurn == 0)
                {
                    Console.WriteLine("No");
                    return;
                }

                if (item == ']')
                {
                    bigBracket--;
                }
            }

            if (sentence[sentence.Length - 1] == '(' || sentence[sentence.Length - 1] == '[')
            {
                Console.WriteLine("No");
                return;
            }

            if (smallBracket == 0 && bigBracket == 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
