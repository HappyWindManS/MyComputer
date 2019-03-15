using System;

namespace ElementaryArithmetic
{
    class Program
    {
        public static int hang;
        public static int lie;
        static void Main(string[] args)
        {

            string[,] a = new string[10, 8];
            hang = a.GetUpperBound(0) + 1;
            lie = a.Length / a.GetUpperBound(0);
            for (int i = 0; i < hang; i++)
            {
                for (int l = 0; l < lie; l++)
                {
                    a[i, l] = random();
                }
            }
            for (int i = 0; i < hang; i++)
            {
                for (int l = 1; l < lie; l = l + 2)
                {
                    a[i, l] = symbol();
                }
            }
            for (int q = 0; q < hang; q++)
            {
                a[q, 7] = "=";
            }
            for (int i = 0; i < hang; i++)
            {
                for (int l = 0; l < lie; l++)
                {
                    Console.Write(a[i, l]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        public static string symbol()
        {
            Random ran = new Random();
            switch (ran.Next(1, 5))
            {
                case 1:
                    return "÷";
                case 2:
                    return "×";
                case 3:
                    return "＋";
                case 4:
                    return "－";
            }
            return "";
        }

        public static string random()
        {
            Random ran = new Random();
            return ran.Next(1, 100).ToString();
        }

    }
}
