using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuShu
{
    class Program
    {
        static void Main(string[] args)
        {
           for (int i = 1; i < 10000; i ++)
            {
                int iSqrt = (int)Math.Sqrt(i);
                for (int j = 1; j <= iSqrt; j ++)
                {
                    if (i % j == 0 && j != 1)
                        break;
                    else if (j == iSqrt&&i!=1)
                        Console.Write(i + " ");
                }
            }
        }
    }
}
