using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 声明不同数据类型变量
{
    class Program
    {
        static void Main(string[] args)
        {
            int Int = 1;
            short Short = 32765;
            uint Uint = 1;
            float Float = 100.15f;
            double Double = -99;
            long Long = 10000;
            decimal Decimal = -1.88m;
            Console.WriteLine("Int:{0},Short:{1},Uint:{2},Float:{3},", Int, Short, Uint, Float);
            Console.WriteLine("Double:{0},Long:{1},Decimal:{2}", Double, Long, Decimal);
            Console.ReadLine();
        }
    }
}
