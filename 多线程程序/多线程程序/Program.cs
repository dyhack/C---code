using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace 多线程程序
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(new ThreadStart(Method1));
            Thread thread2 = new Thread(new ThreadStart(Method2));
            Thread thread3 = new Thread(new ThreadStart(Method3));
            thread3.Priority = ThreadPriority.Highest;
            thread1.Start();
            thread2.Start();
            thread3.Start();
            
        }
        private static void Method1()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.Write("雷");
            }
        }
        private static void Method2()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.Write("元");
            }
 
        }
        private static void Method3()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.Write("刚");
            }
 
        }
    }
}
