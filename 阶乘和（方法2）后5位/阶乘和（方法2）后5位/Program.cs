using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
namespace 阶乘和_方法2_后5位
{


        class Program
        {
            static void Main(string[] args)
            {
                BigInteger s = 0;
                BigInteger k = 1;
                for (int i = 1; i <= 6789; i++)
                {
                    k = k * i;
                    s += k;
                }
                Console.Write(s%100000);
                Console.ReadLine();
            }

        }
    }
