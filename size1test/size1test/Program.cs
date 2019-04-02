using System;
using System.Collections;
using CalculationModuleUWP;
namespace size1test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(CalculationLogic.consequence("＋", 1, 3));
            //Console.WriteLine(CalculationLogic.FractionalConversion("2.25"));
            //Console.WriteLine(CalculationLogic.ReversePolishType("1.5＋5÷2.5×4－7－1"));
            //Console.WriteLine(port.ProblemGeneration("20", "六年级"));
            //for(int i=0;i<100;i++)
            //{
            //    Console.WriteLine(RandomTopic.SixGrade());
            //}
            port port = new port();
            Hashtable hashtable = new Hashtable();
            hashtable = port.ProblemGeneration("20", "六年级");
            foreach (var a in hashtable.Keys)
            {
                Console.WriteLine(a);
            }
            Console.ReadKey();
        }
    }
}
