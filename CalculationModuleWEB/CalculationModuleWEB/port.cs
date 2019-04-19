using System.Collections;

namespace CalculationModuleUWP
{
    /// <summary>
    /// 接口类
    /// </summary>
    public class Port
    {
        /// <summary>
        /// 公用哈希表
        /// </summary>
        private static Hashtable titleHash = new Hashtable();
        /// <summary>
        /// 题目的生成
        /// </summary>
        /// <param name="QuestionNumber"></param>
        /// <param name="grade"></param>
        /// <returns></returns>
        public static Hashtable ProblemGeneration(string questionNumber,string grade)
        {
            switch(grade)
            {
                case "一年级":
                    for(int i=0;i<int.Parse(questionNumber);i++)
                    {
                        try
                        {
                            string title = RandomTopic.FirstGrade();
                            titleHash.Add(title, CalculationLogic.branch(title));
                        }
                        catch
                        {
                            i--;
                        }
                    }
                    break;
                case "二年级":
                    for (int i = 0; i < int.Parse(questionNumber); i++)
                    {
                        try
                        {
                            string title = RandomTopic.SecondGrade();
                            titleHash.Add(title, CalculationLogic.branch(title));
                        }
                        catch
                        {
                            i--;
                        }
                    }
                    break;
                case "三年级":
                    for (int i = 0; i < int.Parse(questionNumber); i++)
                    {
                        try
                        {
                            string title = RandomTopic.ThreeGrade();
                            titleHash.Add(title, CalculationLogic.branch(title));

                        }
                        catch
                        {
                            i--;
                        }
                    }
                    break;
                case "四年级":
                    for (int i = 0; i < int.Parse(questionNumber); i++)
                    {
                        try
                        {
                            string title = RandomTopic.FourGrade();
                            titleHash.Add(title, CalculationLogic.branch(title));
                        }
                        catch
                        {
                            i--;
                        }
                    }
                    break;
                case "五年级":
                    for (int i = 0; i < int.Parse(questionNumber); i++)
                    {
                        try
                        {
                            string title = RandomTopic.FiveGrade();
                            titleHash.Add(title, CalculationLogic.branch(title));
                        }
                        catch
                        {
                            i--;
                        }
                    }
                    break;
                case "六年级":
                    for (int i = 0; i < int.Parse(questionNumber); i++)
                    {
                        try
                        {
                            string title = RandomTopic.SixGrade();
                            titleHash.Add(title, CalculationLogic.branch(title));
                        }
                        catch
                        {
                            i--;
                        }
                    }
                    break;
                case "整数":
                    for (int i = 0; i < int.Parse(questionNumber); i++)
                    {
                        try
                        {
                            string title = RandomTopic.RandomDigit(0, 1);
                            titleHash.Add(title, CalculationLogic.branch(title));
                        }
                        catch
                        {
                            i--;
                        }
                    }
                    break;
                case "小数":
                    for (int i = 0; i < int.Parse(questionNumber); i++)
                    {
                        try
                        {
                            string title = RandomTopic.RandomDigit(1, 2);
                            titleHash.Add(title, CalculationLogic.branch(title));
                        }
                        catch
                        {
                            i--;
                        }
                    }
                    break;
                case "分数":
                    for (int i = 0; i < int.Parse(questionNumber); i++)
                    {
                        try
                        {
                            string title = RandomTopic.RandomDigit(2, 3);
                            titleHash.Add(title, CalculationLogic.branch(title));
                        }
                        catch
                        {
                            i--;
                        }
                    }
                    break;
            }
            return titleHash;
        }
        /// <summary>
        /// 单道题的解题
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
        public static string Branch(string grade)
        {
            if (grade.Contains("/"))
            {
                return CalculationLogic.ProperFraction(CalculationLogic.ScoreReversePolishType(grade));
            }
            else
            {
                return CalculationLogic.ReversePolishType(grade);
            }
        }

    }
}
