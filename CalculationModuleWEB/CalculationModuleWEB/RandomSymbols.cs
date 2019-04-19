using System;
using System.Collections.Generic;
using System.Text;
using CalculationModuleUWP;

namespace CalculationModuleUWP
{
    internal class RandomSymbols
    {
        internal static Random random = new Random();
        /// <summary>
        /// 随机整数
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        internal static string Integer(int min,int max)
        {
            return random.Next(min, max).ToString();
        }
        /// <summary>
        /// 随机小数
        /// </summary>
        /// <param name="min1"></param>
        /// <param name="max1"></param>
        /// <param name="min2"></param>
        /// <param name="max2"></param>
        /// <returns></returns>
        internal static string Decimals(int min1,int max1,int min2,int max2)
        {
            return random.Next(min1, max1).ToString() + "." + random.Next(min2, max2);
        }
        /// <summary>
        /// 随机分数
        /// </summary>
        /// <param name="min1"></param>
        /// <param name="max1"></param>
        /// <param name="min2"></param>
        /// <param name="max2"></param>
        /// <returns></returns>
        internal static string Grade(int min1,int max1,int min2,int max2)
        {
            return random.Next(min1, max1).ToString() + "/" + random.Next(min2, max2);
        }
        /// <summary>
        /// 随机符号
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        internal static string Operators(int min,int max)
        {
            switch (random.Next(min, max))
            {
                case 1:
                    return "＋";
                case 2:
                    return "－";
                case 3:
                    return "×";
                case 4:
                    return "÷";
            }
            return "";
        }
        /// <summary>
        /// 括号
        /// </summary>
        internal static string bracket(string topic)
        {
            Stack<object> stacknum = new Stack<object>();
            Stack<string> stacksymbol = new Stack<string>();
            stacksymbol.Push("#");
            while (topic.Length != 0)
            {
                int length = CalculationLogic.Evaluation(topic);
                if (length == 99)
                {
                    stacknum.Push(Convert.ToDouble(topic.Substring(0, topic.Length)));
                    while (stacknum.Count != 1)
                    {
                        var one = stacknum.Pop();
                        var two = stacknum.Pop();
                        stacknum.Push(CalculationLogic.consequence(stacksymbol.Pop(), Convert.ToDouble(two), Convert.ToDouble(one)));
                    }
                    return stacknum.Peek().ToString();
                }
                if (length != 0)
                {
                    stacknum.Push(Convert.ToDouble(topic.Substring(0, length)));
                    topic = topic.Substring(length, topic.Length - length);
                }
                else if (CalculationLogic.GetOperationLevel(topic.Substring(0, 1)) >
                    CalculationLogic.GetOperationLevel(stacksymbol.Peek()))
                {
                    stacksymbol.Push(topic.Substring(0, 1));
                    topic = topic.Substring(1, topic.Length - 1);
                }
                else
                {
                    var one = stacknum.Pop();
                    var two = stacknum.Pop();
                    stacknum.Push(CalculationLogic.consequence(stacksymbol.Pop(), Convert.ToDouble(two), Convert.ToDouble(one)));
                    stacksymbol.Push(topic.Substring(0, 1));
                    topic = topic.Substring(1, topic.Length - 1);
                }
            }
            return "";
        }
    }
}
