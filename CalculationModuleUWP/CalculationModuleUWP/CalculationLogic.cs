using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.Storage.Streams;

namespace CalculationModuleUWP
{
    public class CalculationLogic
    {
        //待测试
        /// <summary>
        /// 小数转分数
        /// </summary>
        /// <param name="decimals"></param>
        /// <returns></returns>
        public static string FractionalConversion(string decimals)
        {
            int num = decimals.IndexOf(".");
            int length= decimals.Length-1;
            int denominator = 1;
            for (int i=0;i<length-num;i++)
            {
                denominator = denominator * 10;
            }
            return reductionOfFraction(decimals.Replace(".", "") + "/"+denominator.ToString());
        }
        /// <summary>
        /// 分数约分
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
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
        /// <summary>
        /// 分数的换算
        /// </summary>
        /// <param name="symbol"></param>
        /// <param name="one"></param>
        /// <param name="two"></param>
        /// <returns></returns>
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
                return reductionOfFraction((elementOne * elementTwo).ToString() + "/" + denominatorTwo.ToString());
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
            string strin = consequence(symbol,elementOne,elementTwo);
            return reductionOfFraction(strin + "/" + denominatorTwo);
        }
        /// <summary>
        /// 最基础的加减乘除的方法
        /// </summary>
        /// <param name="symbol"></param>
        /// <param name="one"></param>
        /// <param name="two"></param>
        /// <returns></returns>
        public static string consequence(string symbol,double one,double two)
        {
            switch(symbol)
            {
                case "＋":
                    return (one + two).ToString();
                case "－":
                    return (one - two).ToString();
                case "×":
                    return (one * two).ToString();
                case "÷":
                    return (one / two).ToString();
            }
            return "";
        }
        /// <summary>
        /// 逆波兰式
        /// </summary>
        public static string ReversePolishType(string strEquation)
        {
            Stack<object> stacknum = new Stack<object>();      
            Stack<string> stacksymbol = new Stack<string>();
            stacksymbol.Push("#");
            while (strEquation.Length!=0)
            {
                int length = Evaluation(strEquation);
                if (length == 99)
                {
                    stacknum.Push(Convert.ToDouble(strEquation.Substring(0,strEquation.Length)));
                    while (stacknum.Count!=1)
                    {
                        var one = stacknum.Pop();
                        var two = stacknum.Pop();
                        stacknum.Push(consequence(stacksymbol.Pop(), Convert.ToDouble(two), Convert.ToDouble(one)));
                    }
                    return stacknum.Peek().ToString();
                }
                if (length != 0)
                {
                    stacknum.Push(Convert.ToDouble(strEquation.Substring(0, length)));
                    strEquation = strEquation.Substring(length, strEquation.Length - length);
                }
                else if(GetOperationLevel(strEquation.Substring(0,1))>
                    GetOperationLevel(stacksymbol.Peek()))
                {
                    stacksymbol.Push(strEquation.Substring(0, 1));
                    strEquation = strEquation.Substring(1, strEquation.Length - 1);
                }
                else
                {
                    var one = stacknum.Pop();
                    var two = stacknum.Pop();
                    stacknum.Push(consequence(stacksymbol.Pop(),Convert.ToDouble(two),Convert.ToDouble(one)));
                    stacksymbol.Push(strEquation.Substring(0, 1));
                    strEquation = strEquation.Substring(1, strEquation.Length - 1);
                }          
            }
            return stacknum.Pop().ToString();
        }
        /// <summary>
        /// 取出操作数或运算符的索引
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public static int Evaluation(string topic)
        {
            if(topic.Substring(0,1)!= "＋"&& topic.Substring(0, 1) != "－" 
                && topic.Substring(0, 1) != "×" && topic.Substring(0, 1) != "÷" )
            {
                int[] min=new int[4];
                min[0] = topic.IndexOf("＋");
                min[1] = topic.IndexOf("－");
                min[2] = topic.IndexOf("×");
                min[3] = topic.IndexOf("÷");
                for(int i=0; i < min.Length ;i++)
                {
                    if(min[i]<0)
                    {
                        min[i] = min[i] + 100;
                    }
                }
                return min.Min();
            }        
            else
            {
                return 0;
            }
        }
        /// <summary>
        /// 获取运算符等级
        /// </summary>
        /// <param name="c">当前字符</param>
        /// <returns></returns>
        public static int GetOperationLevel(string c)
        {
            switch (c)
            {
                case "＋": return 1;
                case "－": return 1;
                case "×": return 2;
                case "÷": return 2;
                case "#": return -1;
                case "(": return -1;
                case ")": return -1;
                default: return 0;
            }
        }
        /// <summary>
        /// 保存答案生成TXT，可选择路径
        /// </summary>
        /// <param name="strtxt">保存的文本</param>
        /// <param name="filename">文件名</param>
        public async void SaveTxt(string strtxt, string filename)
        {
            FileSavePicker fp = new FileSavePicker();
            var filedb = new[] { ".txt" };
            fp.FileTypeChoices.Add(".txt", filedb);
            //fp.SuggestedFileName = "Answer " + DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day;
            fp.SuggestedFileName = filename;
            StorageFile sf = await fp.PickSaveFileAsync();
            if (sf != null)
            {
                using (StorageStreamTransaction transaction = await sf.OpenTransactedWriteAsync())
                {
                    using (DataWriter dataWriter = new DataWriter(transaction.Stream))
                    {
                        dataWriter.WriteString(strtxt);
                        transaction.Stream.Size = await dataWriter.StoreAsync();
                        await transaction.CommitAsync();
                    }
                }
            }
        }
        /// <summary>
        /// 生成题目
        /// </summary>
        //public static void GenerateTitle()

        //{
        //    FileStream fs = new FileStream("D:\\四则运算.txt", FileMode.Create);
        //    //答案的TXT
        //    FileStream da = new FileStream("D:\\四则运算的答案.txt", FileMode.Create);
        //    int plus = 1;
        //    foreach (string a in titlehash.Keys)
        //    {
        //        //获得字节数组
        //        byte[] data = System.Text.Encoding.Default.GetBytes("第" + plus + "题." + a + " =" + "\r\n");
        //        //开始写入
        //        fs.Write(data, 0, data.Length);
        //        plus++;
        //    }
        //    //清空缓冲区、关闭流
        //    fs.Flush();
        //    fs.Close();
        //    plus = 1;
        //    foreach (string b in titlehash.Values)
        //    {
        //        //获得字节数组
        //        byte[] data = System.Text.Encoding.Default.GetBytes("第" + plus + "题:" + b + "\r\n");
        //        //开始写入
        //        da.Write(data, 0, data.Length);
        //        plus++;
        //    }
        //    //清空缓冲区、关闭流
        //    da.Flush();
        //    da.Close();
        //}
        ///// <summary>
        ///// 获取完整数值
        ///// </summary>
        ///// <param name="formula">公式</param>
        ///// <returns></returns>
        //private static int GetCompleteValue(string formula)
        //{
        //    int index = formula.Length;
        //    for (int i = 0; i < formula.Length; i++)
        //    {
        //        int num = GetOperationLevel(formula[i].ToString());
        //        if (num != 0)
        //        {
        //            index = i;
        //            break;
        //        }
        //    }
        //    return index;
        //}
        ///// <summary>
        ///// 移动运算符
        ///// </summary>
        ///// <param name="opStack"></param>
        ///// <param name="numStack"></param>
        //private static void MoveOperator(Stack<string> opStack, Stack<string> numStack)
        //{
        //    string s = opStack.Pop();
        //    if (s == "(")
        //    {
        //        return;
        //    }
        //    else
        //    {
        //        numStack.Push(s);
        //        MoveOperator(opStack, numStack);
        //        return;
        //    }
        //}
        ///// <summary>
        ///// 判断运算符
        ///// </summary>
        ///// <param name="opStack"></param>
        ///// <param name="numStack"></param>
        ///// <param name="x"></param>
        //private static void JudgeOperator(Stack<string> opStack, Stack<string> numStack, string x)
        //{
        //    int xNum = GetOperationLevel(x);
        //    int opNum = GetOperationLevel(opStack.Peek());
        //    if (xNum > opNum || numStack.Peek() == "(")
        //    {
        //        opStack.Push(x);
        //        return;
        //    }
        //    else
        //    {
        //        string opStr = opStack.Pop();
        //        numStack.Push(opStr);
        //        JudgeOperator(opStack, numStack, x);
        //        return;
        //    }
        //}
        //无分数结果验算
        //public static string consequence(string equation)
        //{
        //    //小数与整数运算           
        //    string formula = equation.Replace("÷", "/");
        //    formula = formula.Replace("×", "*");
        //    formula = formula.Replace("＋", "+");
        //    formula = formula.Replace("－", "-");
        //    System.Data.DataTable dt = new System.Data.DataTable();
        //    string really_data = dt.Compute(formula, "false").ToString();
        //    return really_data;
        //}
        //分数的验算
        //    public static string fractionalArithmetic(string symbol, string one, string two)
        //    {
        //        one = one.Replace(" ", "");
        //        two = two.Replace(" ", "");
        //        //取出第一个数的分子和分母
        //        int indexesOne = one.IndexOf("/");
        //        int elementOne = int.Parse(one.Substring(0, indexesOne));
        //        //int denominatorOne = int.Parse(one.Substring(indexesOne + 1, one.Length-1));
        //        int denominatorOne = int.Parse(one.Substring(indexesOne + 1, one.Length - indexesOne - 1));
        //        //记录第一个数的分母
        //        //int lalal = denominatorOne;
        //        //取出第二个数的分子和分母
        //        int indexesTwo = two.IndexOf("/");
        //        int elementTwo = int.Parse(two.Substring(0, indexesTwo));
        //        int denominatorTwo = int.Parse(two.Substring(indexesTwo + 1, two.Length - indexesTwo - 1));
        //        //分母相乘
        //        denominatorTwo = denominatorTwo * denominatorOne;
        //        //如果是乘法，直接用分子乘以分子，分母乘以分母
        //        if (symbol == "×")
        //        {
        //            return reductionOfFraction((elementOne * elementTwo).ToString() + "/" + denominatorTwo);
        //        }
        //        //假设第一个数第二个数之间的公约数都是对方,计算第一个数分子的倍数
        //        elementOne = elementOne * denominatorTwo;
        //        //第二个数分子的倍数
        //        elementTwo = elementTwo * denominatorOne;

        //        //如果是除法
        //        if (symbol == "÷")
        //        {
        //            return reductionOfFraction((elementOne.ToString() + "/" + elementTwo.ToString()));
        //        }
        //        //第一个分子与第二个分子的换算
        //        string strin = consequence(elementOne + symbol + elementTwo);
        //        return reductionOfFraction(strin + "/" + denominatorTwo);
        //    }
        //    //六年级题目的解法
        //    public static string solution(string topic)
        //    {
        //        string[] array = new string[5];
        //        int i = 0;
        //        foreach (var a in topic)
        //        {
        //            if (a.ToString() == "＋" || a.ToString() == "－" || a.ToString() == "×" || a.ToString() == "÷")
        //            {
        //                i++;
        //                array[i] += a;
        //                i++;
        //            }
        //            else
        //            {
        //                array[i] += a;
        //            }
        //        }
        //        for (int l = 0; l < array.Length; l++)
        //        {
        //            if (array[l] == "×" || array[l] == "÷")
        //            {
        //                if (l == 3)
        //                {
        //                    return fractionalArithmetic(array[1], array[0], fractionalArithmetic(array[l], array[l - 1], array[l + 1]));
        //                }
        //            }
        //        }
        //        return fractionalArithmetic(array[3], fractionalArithmetic(array[1], array[0], array[2]), array[4]);
        //    }
        //}
    }
}
