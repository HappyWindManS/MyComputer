using System;
using System.Collections;
using System.Threading;
using SchedulingSimulation;
namespace SchedulingSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            vehicle dong = new vehicle()
            {
                name = "东"         
            };
            vehicle xi = new vehicle()
            {
                name = "西",
            };
            vehicle nan = new vehicle()
            {
                name = "南",
            };
            vehicle bei = new vehicle()
            {
                name = "北",
            };
            Random random = new Random();
            Queue queue = new Queue();
            queue.Enqueue(false);
            queue.Enqueue(true);
            var logic = new logic();
            Console.WriteLine("东西道路为主道，南北则为支道");
            Console.WriteLine("三十秒等太久，五秒我觉得可以");
            Thread.Sleep(2000);
            Console.WriteLine("十字路口瞎控制系统启动");
            Thread.Sleep(1000);
            logic.QWQ();
            while(queue.Count==2)
            {
                bool IAmTheMostHandsome = (bool)queue.Dequeue();               
                logic.MasterControl(IAmTheMostHandsome);
                queue.Enqueue(IAmTheMostHandsome);
                foreach (var item in SimulationOfCarColumn())
                {
                    dong.queue.Enqueue(item);
                }
                foreach (var item in SimulationOfCarColumn())
                {
                    xi.queue.Enqueue(item);
                }
                foreach (var item in SimulationOfCarColumn())
                {
                    nan.queue.Enqueue(item);
                }
                foreach (var item in SimulationOfCarColumn())
                {
                    bei.queue.Enqueue(item);
                }
                if (IAmTheMostHandsome)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        if (dong.queue.Count != 0)
                        {
                            Console.WriteLine("现在" + dong.name + "车道" + dong.queue.Dequeue());
                        }
                        if (xi.queue.Count != 0)
                        {
                            Console.WriteLine("现在" + xi.name + "车道" + xi.queue.Dequeue());
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < 10; i++)
                    {
                        if(nan.queue.Count!=0)
                        {
                            Console.WriteLine("现在" + nan.name + "车道" + nan.queue.Dequeue());
                        }
                        if (bei.queue.Count != 0)
                        {
                            Console.WriteLine("现在" + bei.name + "车道" + bei.queue.Dequeue());
                        }
                    }
                }
                Thread.Sleep(10000);
                if (random.Next(0,4)==0)
                {
                    night();
                    Console.WriteLine("-----------------------白天----------------------------");
                }
            }
            Console.ReadKey();
        }
        public static void night()
        {
            var logic = new logic();
            Random random = new Random();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("----------------进入夜晚-----------------------");
            logic.CrossroadConditionRed(true);
            logic.CrossroadConditionGreen(false);
            logic.QWQ();
            for (int i= 0;i < random.Next(3, 6);i++)
            {
                if(random.Next(0,1)==0)
                {
                    logic.MasterControl(false);
                    Console.WriteLine(GenerateVehicle());
                    logic.MasterControl(true);
                }
            }
        }

        public class vehicle
        {
            public string name;
            public Queue queue = new Queue();
            public vehicle()
            {
                foreach (var item in SimulationOfCarColumn())
                    queue.Enqueue(item);
            }
        }

        public static Queue SimulationOfCarColumn()
        {
            Random random = new Random();
            Queue queue = new Queue();
            for(int i=0;i<random.Next(0,10);i++)
            {
                queue.Enqueue(GenerateVehicle());
            }
            return queue;
        }

        public static string GenerateVehicle()
        {
            string ret = "";
            Random random = new Random();
            switch (random.Next(1,10))
            {
                case 1:
                    ret += "黑色";
                    break;
                case 2:
                    ret += "蓝色";
                    break;
                case 3:
                    ret += "绿色";
                    break;
                case 4:
                    ret += "红色";
                    break;
                case 5:
                    ret += "橙色";
                    break;
                case 6:
                    ret += "紫色";
                    break;
                case 7:
                    ret += "青色";
                    break;
                case 8:
                    ret += "土豪金色";
                    break;
                case 9:
                    ret += "白色";
                    break;
                default:
                    ret += "掉了漆";
                    break;
            }
            switch (random.Next(1, 10))
            {
                case 1:
                    ret += "的丰田";
                    break;
                case 2:
                    ret += "的奔驰";
                    break;
                case 3:
                    ret += "的宝马";
                    break;
                case 4:
                    ret += "的本田";
                    break;
                case 5:
                    ret += "的五菱";
                    break;
                case 6:
                    ret += "的宝骏";
                    break;
                case 7:
                    ret += "的长城";
                    break;
                case 8:
                    ret += "的法拉利";
                    break;
                case 9:
                    ret += "的玛莎拉蒂";
                    break;
                default:
                    ret += "的兰博基尼";
                    break;
            }
            switch (random.Next(1, 9))
            {
                case 1:
                    ret += "小轿车正在路过";
                    break;
                case 2:
                    ret += "老爷车正在路过";
                    break;
                case 3:
                    ret += "商务车正在路过";
                    break;
                case 4:
                    ret += "防弹车正在路过";
                    break;
                case 5:
                    ret += "卡车正在路过";
                    break;
                case 6:
                    ret += "越野车正在路过";
                    break;            
                default:
                    ret += "直升飞机正在路过";
                    break;
            }
            return ret;
        }
    }
}
