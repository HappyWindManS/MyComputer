using System;
using System.Collections;

namespace FundamentalTheoremOfArithmetic
{
    class Program
    {
        public Stack stack = new Stack();
        public Stack prime = new Stack();
        static void Main(string[] args)
        {
            Console.WriteLine("唯一析因定理是一个有趣的东西");
            Console.WriteLine("它能将一个分解为一个又一个质数");
            Console.WriteLine("这是初等数论的内容");
            Console.WriteLine("比如，");
        }

        public static void GetPrime()
        {
            for(int i=0;i<10000;i++)
            {

            }
        }

        public int Resolve(int num)
        {
            if(prime.Contains(num))
            {
                return num;
            }
            else
            {

                return Resolve(num);
            }
        }
    }
}
