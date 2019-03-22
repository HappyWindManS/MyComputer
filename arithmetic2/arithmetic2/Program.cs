using System;
//哈希表
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;


namespace arithmetic2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入要生成的题数");
            int quantity = int.Parse(Console.ReadLine());
            Console.WriteLine("请选择难度（输入1为四年级，整数运算，输入2为五年级，带有限小数运算，输入3为六年级,带分数运算)\n输入4混合运算，生成时间较久！");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入运算范围");
            int scope = int.Parse(Console.ReadLine());
            //生成题目的类
            generateTheTitle generateTheTitle = new generateTheTitle();
            //生成答案的类
            solve_problems solve_Problems = new solve_problems();
            //利用哈希表进行数据的存储与查重
            Hashtable fourOperations = new Hashtable();
            Console.WriteLine("正在生成题目,请稍等");
            switch (num)
            {
                case 1:
                    #region 四年级题目
                    for (int i = 0; i < quantity; i++)
                    {
                        string topic = (generateTheTitle.topicfour(scope));
                        string answer = (solve_problems.consequence(topic));
                        if (fourOperations.Contains(topic))
                        {
                            i--;
                            break;
                        }
                        if (Convert.ToDouble(answer) > 0)
                        {
                            fourOperations.Add(topic, answer);
                        }
                        else
                        {
                            i--;
                        }
                    }
                    break;
                #endregion
                case 2:
                    #region 五年级题目
                    for (int i = 0; i < quantity; i++)
                    {
                        string topic = (generateTheTitle.topicfive(scope));
                        string answer = (solve_problems.consequence(topic));
                        if (fourOperations.Contains(topic))
                        {
                            i--;
                            break;
                        }
                        if (Convert.ToDouble(answer) > 0)
                        {
                            fourOperations.Add(topic, answer);
                        }
                        else
                        {
                            i--;
                        }
                    }
                    break;
                #endregion
                case 3:
                    #region 六年级题目
                    for (int i = 0; i < quantity; i++)
                    {
                        string topic = (generateTheTitle.topicssix(scope));
                        string answer = (solve_problems.solution(topic));
                        answer = solve_problems.reductionOfFraction(answer);
                        if (fourOperations.Contains(topic))
                        {
                            i--;
                            break;
                        }
                        if (Convert.ToDouble(solve_problems.consequence(answer)) > 0)
                        {
                            fourOperations.Add(topic, answer);
                        }
                        else
                        {
                            i--;
                        }
                    }
                    break;
                #endregion
                case 4:
                    #region 混合运算题目
                    for (int i = 0; i < quantity; i++)
                    {
                        //Console.WriteLine(mixture(scope));
                    }
                    #endregion
                    break;
            }
            #region 写入TXT
            //题目的TXT
            FileStream fs = new FileStream("D:\\四则运算.txt", FileMode.Create);
            //答案的TXT
            FileStream da = new FileStream("D:\\四则运算的答案.txt", FileMode.Create);
            int plus = 1;
            foreach (string a in fourOperations.Keys)
            {
                //获得字节数组
                byte[] data = System.Text.Encoding.Default.GetBytes("第" + plus + "题." + a + " =" + "\r\n");
                //开始写入
                fs.Write(data, 0, data.Length);
                plus++;
            }
            //清空缓冲区、关闭流
            fs.Flush();
            fs.Close();
            plus = 1;
            foreach (string b in fourOperations.Values)
            {
                //获得字节数组
                byte[] data = System.Text.Encoding.Default.GetBytes("第" + plus + "题:" + b + "\r\n");
                //开始写入
                da.Write(data, 0, data.Length);
                plus++;
            }
            //清空缓冲区、关闭流
            da.Flush();
            da.Close();
            #endregion
            Console.WriteLine("生成完毕");
            Console.ReadKey();
        }


        //分数运算
        public static string operation(string symbol, string num1, string num2)
        {

            return "";
        }
    }
}
