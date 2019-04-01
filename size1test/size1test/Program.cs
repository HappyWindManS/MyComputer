using System;
using CalculationModuleUWP;
namespace size1test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(CalculationLogic.consequence("＋", 1, 3));
            //Console.WriteLine(CalculationLogic.FractionalConversion("3.7894"));
            Console.WriteLine(CalculationLogic.ReversePolishType("1.5＋5÷2.5×4－7－1"));
            Console.ReadKey();
        }
    }
}
