using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;

namespace SchedulingSimulation
{
    public class logic
    {
        TrafficLight east = new TrafficLight()
        {
            GreenLight = 1,
            RedLight = 0,
            YellowLight = 0,
            name = "东"
        };
        TrafficLight west = new TrafficLight()
        {
            GreenLight = 1,
            RedLight = 0,
            YellowLight = 0,
            name = "西"
        };
        TrafficLight south = new TrafficLight()
        {
            GreenLight = 0,
            RedLight = 1,
            YellowLight = 0,
            name = "南"
        };
        TrafficLight north = new TrafficLight()
        {
            GreenLight = 0,
            RedLight = 1,
            YellowLight = 0,
            name = "北"
        };
    
        //转换绿灯状态
        public void CrossroadConditionGreen(bool bo)
        {
            if (bo)
            {
                east.RedConGreen();
                west.RedConGreen();
            }
            else
            {
                south.RedConGreen();
                north.RedConGreen();
            }
        }
        //转换红灯状态
        public void CrossroadConditionRed(bool bo)
        {
            if (bo)
            {
                east.YellowConRed();
                west.YellowConRed();
            }
            else
            {
                south.YellowConRed();
                north.YellowConRed();
            }
        }
        //转换黄灯状态
        public void CrossroadConditionYellow(bool bo)
        {
            if (bo)
            {
                east.GreenConYellow();
                west.GreenConYellow();
            }
            else
            {
                south.GreenConYellow();
                north.GreenConYellow();
            }
        }

        public void QWQ()
        {
            QAQ(east); QAQ(west); QAQ(south); QAQ(north);
        }
        public void MasterControl(bool bo)
        {
            CrossroadConditionYellow(!bo);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("开始等待三秒黄灯");
            QWQ();
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("......= =");
            Thread.Sleep(1000);
            Console.Write("......= =");
            Thread.Sleep(1000);
            Console.WriteLine("......= =");
            CrossroadConditionRed(!bo);
            CrossroadConditionGreen(bo);
            QWQ();
            Thread.Sleep(3000);
        }

        public void Unscramble()
        {
            Console.WriteLine();
        }

        public void QAQ(TrafficLight trafficLight)
        {
            if (trafficLight.GreenLight == 1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(trafficLight.name+"道为绿灯");
            }
            if(trafficLight.YellowLight==1)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(trafficLight.name + "道为黄灯");
            }
            if(trafficLight.RedLight==1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(trafficLight.name + "道为红灯");
            }
        }
    }
}
