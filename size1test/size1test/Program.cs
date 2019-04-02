using System;
using CalculationModuleUWP;
namespace size1test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CalculationLogic.consequence("＋", 1, 3));
            Console.WriteLine(CalculationLogic.FractionalConversion("2.25"));
            Console.WriteLine(CalculationLogic.ReversePolishType("1.5＋5÷2.5×4－7－1"));
            Console.WriteLine(CalculationLogic.fractionalArithmetic("＋","4/3","7/8"));
            //for(int i=0;i<100;i++)
            //{
            //    Console.WriteLine(RandomTopic.SixGrade());
            //}
            Console.ReadKey();
        }
    }
}
