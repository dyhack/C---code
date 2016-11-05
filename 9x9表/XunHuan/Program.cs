using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XunHuan
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i.ToString() + "*" + j.ToString() + "=" + (i * j).ToString()+"  ");
                }
                Console.WriteLine();                
            }
        }
    }
}
