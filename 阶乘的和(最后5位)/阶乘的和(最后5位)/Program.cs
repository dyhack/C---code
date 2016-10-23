using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading;
namespace 阶乘的和_最后5位_
{


    
        class Program
        {
            public static BigInteger jiecheng(BigInteger n)
            {
                if (n == 0)
                    return 1;
                else
                    return (n*jiecheng(n - 1))%100000;
            }
            static void Main(string[] args)
            {
                
                Console.Write("enter n:");
                int n = int.Parse(Console.ReadLine());
                BigInteger sum = 0;

                for (int i = 1; i <= n; i++)
                {
                    sum += (jiecheng(i));
;
                }
                Console.WriteLine(sum % 100000);

                Console.Read();
            }
        }
    
}
