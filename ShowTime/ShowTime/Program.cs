using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace ShowTime
{
    class Program
    {

        
        static void Main(string[] args)
        {
            string nowstr = "";
            string[] day = { "星期天", "星期一", "星期二", "星期三", "星期四", "星期五", "星期六", };
            DateTime begin = new DateTime(2016,9,1);
            DateTime end = new DateTime(2017, 1, 20);
            while (true)
            {
                DateTime datetime = DateTime.Now;
                nowstr = string.Format("{0:现在是yyyy年MM月dd日 H点m分ss秒},{1}", datetime, day[(Convert.ToInt32(datetime.DayOfWeek))]);
                nowstr += "\n从开学到现在一共" + ((datetime - begin)).Days+"天";
                nowstr+="\n距离放假还有"+(end-datetime).Days+"天";
                Console.Clear();
                Console.WriteLine(nowstr);
                Thread.Sleep(1000);
            }
            

        }
    }
}
