using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace arithmetic2
{
    /// <summary>
    /// 解题的方法
    /// </summary>
    public class solve_problems
    {
        //小数转分数
        public static string FractionalConversion(string decimals)
        {
            //因为小数只生成一位小数，所以分母可以确定为2-10，公约数为2/3/5
            //    int indexes = decimals.IndexOf(".");
            //    string conv = decimals.Substring(indexes+1, decimals.Length);
            //    return reductionOfFraction(conv+"/10");
            //将数*10再进行约分
            return reductionOfFraction(decimals.Replace(".", "") + "/10");
        }
        //分数约分
        public static string reductionOfFraction(string grade)
        {
            int indexes = grade.IndexOf("/");
            int element = int.Parse(grade.Substring(0, indexes));
            int denominator = int.Parse(grade.Substring(indexes + 1, grade.Length - indexes - 1));
            int min = Math.Min(element, denominator);
            for (int i = 2; i < min; i++)
            {
                if (element % i == 0 && denominator % i == 0)
                {
                    element = element / i;
                    denominator = denominator / i;
                    min = Math.Min(element, denominator);
                    i = 1;
                }
            }
            return element.ToString() + "/" + denominator;
        }
        //无分数结果验算
        public static string consequence(string equation)
        {
            //小数与整数运算           
            string formula = equation.Replace("÷", "/");
            formula = formula.Replace("×", "*");
            formula = formula.Replace("＋", "+");
            formula = formula.Replace("－", "-");
            DataTable dt = new DataTable();
            string really_data = dt.Compute(formula, "false").ToString();
            return really_data;
        }
        //分数的验算
        public static string fractionalArithmetic(string symbol, string one, string two)
        {
            one = one.Replace(" ", "");
            two = two.Replace(" ", "");
            //取出第一个数的分子和分母
            int indexesOne = one.IndexOf("/");
            int elementOne = int.Parse(one.Substring(0, indexesOne));
            //int denominatorOne = int.Parse(one.Substring(indexesOne + 1, one.Length-1));
            int denominatorOne = int.Parse(one.Substring(indexesOne + 1, one.Length - indexesOne - 1));
            //记录第一个数的分母
            //int lalal = denominatorOne;
            //取出第二个数的分子和分母
            int indexesTwo = two.IndexOf("/");
            int elementTwo = int.Parse(two.Substring(0, indexesTwo));
            int denominatorTwo = int.Parse(two.Substring(indexesTwo + 1, two.Length - indexesTwo - 1));
            //分母相乘
            denominatorTwo = denominatorTwo * denominatorOne;
            //如果是乘法，直接用分子乘以分子，分母乘以分母
            if (symbol == "×")
            {
                return reductionOfFraction((elementOne * elementTwo).ToString() + "/" + denominatorTwo);
            }
            //假设第一个数第二个数之间的公约数都是对方,计算第一个数分子的倍数
            elementOne = elementOne * denominatorTwo;
            //第二个数分子的倍数
            elementTwo = elementTwo * denominatorOne;

            //如果是除法
            if (symbol == "÷")
            {
                return reductionOfFraction((elementOne.ToString() + "/" + elementTwo.ToString()));
            }
            //第一个分子与第二个分子的换算
            string strin = consequence(elementOne + symbol + elementTwo);
            return reductionOfFraction(strin + "/" + denominatorTwo);

        }
        //六年级题目的解法
        public static string solution(string topic)
        {
            string[] array = new string[5];
            int i = 0;
            foreach (var a in topic)
            {
                if (a.ToString() == "＋" || a.ToString() == "－" || a.ToString() == "×" || a.ToString() == "÷")
                {
                    i++;
                    array[i] += a;
                    i++;
                }
                else
                {
                    array[i] += a;
                }
            }
            for (int l = 0; l < array.Length; l++)
            {
                if (array[l] == "×" || array[l] == "÷")
                {
                    if (l == 3)
                    {
                        return fractionalArithmetic(array[1], array[0], fractionalArithmetic(array[l], array[l - 1], array[l + 1]));
                    }
                }
            }
            return fractionalArithmetic(array[3], fractionalArithmetic(array[1], array[0], array[2]), array[4]);
        }
    }
}
