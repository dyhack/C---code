using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
namespace 斐波那契数列
{
    class Program
    {
        static  BigInteger[] num = new BigInteger[200];
        public static void fbnq(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                if (i < 3)
                {
                    num[0] = num[1] = num[2] = 11;

                }
                else
                {
                    num[i] = num[i - 1] + num[i - 2] + num[i - 3];
                }
               
            }
            Console.WriteLine(num[99]);
        }
        static void Main(string[] args)
        {
            int i=int.Parse(Console.ReadLine());
            fbnq(i);
        }
    }
}
