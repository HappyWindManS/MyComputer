using System;

namespace arithmeticTWO
{
    class Program
    {
        static void Main(string[] args)
        {
            //string num = "123456123";
            //Console.WriteLine(num);
            //num = num.Replace("123", "");
            //Console.WriteLine(num);

            string str= "123456";
            string num=str.Substring(0,3);
            string lalal=str.Substring(2, str.Length-2);
            Console.WriteLine(num);
            Console.WriteLine(lalal);

            Console.ReadKey();
        }
    }
}
