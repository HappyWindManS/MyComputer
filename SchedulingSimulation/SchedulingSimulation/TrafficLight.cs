using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SchedulingSimulation
{
    public class TrafficLight
    {
        //红灯的值
        public int RedLight;
        //绿灯的值
        public int GreenLight;
        //黄灯的值
        public int YellowLight;

        public string name;

        #region 状态控制
        //绿转黄
        public void GreenConYellow()
        {
            RedLight = 0;
            GreenLight = 0;
            YellowLight = 1;
        }

        //黄转红
        public void YellowConRed()
        {
            RedLight = 1;
            GreenLight = 0;
            YellowLight = 0;
        }

        //红转绿
        public void RedConGreen()
        {
            RedLight = 0;
            GreenLight = 1;
            YellowLight = 0;
        }
        #endregion


    }
}
