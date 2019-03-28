using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationModuleUWP
{
    internal class RandomTopic
    {
        /// <summary>
        /// 一年级
        /// </summary>
        internal static string FirstGrade()
        {
            return RandomSymbols.Integer(0, 20) + RandomSymbols.Operators(1, 3) + RandomSymbols.Integer(0, 20);
        }
        /// <summary>
        /// 二年级
        /// </summary>
        /// <returns></returns>
        internal static string SecondGrade()
        {
            return RandomSymbols.Integer(10, 100) + RandomSymbols.Operators(1,3) + RandomSymbols.Integer(10, 100);

        }
        /// <summary>
        /// 三年级
        /// </summary>
        /// <returns></returns>
        internal static string ThreeGrade()
        {
            return RandomSymbols.Integer(10, 100) + RandomSymbols.Operators(3, 5) + RandomSymbols.Integer(10, 100);
        }
        /// <summary>
        /// 四年级
        /// </summary>
        /// <returns></returns>
        internal static string FourGrade()
        {
            string equation = RandomSymbols.Integer(1, 1000);
            for (int i=0;i<2;i++)
            {
                equation += RandomSymbols.Operators(1, 5) + RandomSymbols.Integer(1, 1000) + RandomSymbols.Operators(1, 5);
            }
            return equation;
        }
        /// <summary>
        /// 五年级的题目
        /// </summary>
        /// <returns></returns>
        internal static string FiveGrade()
        {
            
        }
    }
}
