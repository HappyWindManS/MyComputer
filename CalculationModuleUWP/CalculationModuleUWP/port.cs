using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationModuleUWP
{
    /// <summary>
    /// 接口类
    /// </summary>
    public class port
    {
        private static Hashtable titleHash = new Hashtable();
        public static Hashtable ProblemGeneration(string QuestionNumber,string grade)
        {
            switch(grade)
            {
                case "一年级":
                    for(int i=0;i<int.Parse(QuestionNumber);i++)
                    {
                        string title = RandomTopic.FirstGrade();
                        titleHash.Add(title, CalculationLogic.branch(title));
                    }
                    break;
                case "二年级":
                    for (int i = 0; i < int.Parse(QuestionNumber); i++)
                    {
                        string title = RandomTopic.SecondGrade();
                        titleHash.Add(title, CalculationLogic.branch(title));
                    }
                    break;
                case "三年级":
                    for (int i = 0; i < int.Parse(QuestionNumber); i++)
                    {
                        string title = RandomTopic.ThreeGrade();
                        titleHash.Add(title, CalculationLogic.branch(title));
                    }
                    break;
                case "四年级":
                    for (int i = 0; i < int.Parse(QuestionNumber); i++)
                    {
                        string title = RandomTopic.FourGrade();
                        titleHash.Add(title, CalculationLogic.branch(title));
                    }
                    break;
                case "五年级":
                    for (int i = 0; i < int.Parse(QuestionNumber); i++)
                    {
                        string title = RandomTopic.FiveGrade();
                        titleHash.Add(title, CalculationLogic.branch(title));
                    }
                    break;
                case "六年级":
                    for (int i = 0; i < int.Parse(QuestionNumber); i++)
                    {
                        string title = RandomTopic.SixGrade();
                        titleHash.Add(title, CalculationLogic.branch(title));
                    }
                    break;
                case "整数":
                    for (int i = 0; i < int.Parse(QuestionNumber); i++)
                    {
                        string title = RandomTopic.RandomDigit(0,1);
                        titleHash.Add(title, CalculationLogic.branch(title));
                    }
                    break;
                case "小数":
                    for (int i = 0; i < int.Parse(QuestionNumber); i++)
                    {
                        string title = RandomTopic.RandomDigit(1,2);
                        titleHash.Add(title, CalculationLogic.branch(title));
                    }
                    break;
                case "分数":
                    for (int i = 0; i < int.Parse(QuestionNumber); i++)
                    {
                        string title = RandomTopic.RandomDigit(2,3);
                        titleHash.Add(title, CalculationLogic.branch(title));
                    }
                    break;
            }
            return titleHash;
        }
    }
}
