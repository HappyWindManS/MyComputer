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
            //Console.WriteLine(Port.Branch("7/8－61/8"));
            //Console.WriteLine(port.ProblemGeneration("20", "六年级"));
            //for(int i=0;i<100;i++)
            //{
            //    Console.WriteLine(RandomTopic.SixGrade());
            //}
            Hashtable hashtable = new Hashtable();
            hashtable = Port.ProblemGeneration("20", "六年级");
            int i = 1;
            foreach (var a in hashtable.Keys)
            {
                Console.WriteLine(i + ". " + a);
                i++;
            }
            i = 1;
            foreach (var a in hashtable.Values)
            {
                Console.WriteLine(i + ". " + a);
                i++;
            }
            //Console.WriteLine(Port.Branch("1/4＋1/2÷4/7×4－7/2－1"));
            Console.ReadKey();
        }
    }
}
