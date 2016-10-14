using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 简单复数类
{

    class Program
    {
        static void Main(string[] args)
        {
            Complex ex = new Complex(1.2,3.2);
            Complex ex1 = new Complex(2, 3);
            ex.Add(ex);
            ex.Sub(ex1);
        }
    } 
    /// <summary>
    /// 实现加法和减法的简单复数类
    /// </summary>
    class Complex
    {
        private double real, image;
        /// <summary>
        /// 无参构造函数
        /// </summary>
        public Complex()
        {
            real = 0;
            image = 0;
 
        }
        /// <summary>
        /// 带参构造函数
        /// </summary>
        /// <param name="real">实部的初始值</param>
        /// <param name="image">虚部的初始值</param>
        public Complex(double real, double image)
        {
            this.real = real;
            this.image = image;
        }
        /// <summary>
        /// 复数的相加
        /// </summary>
        /// <param name="complex">表示要相加的复数</param>
        public void Add(Complex complex)
        {
            Console.WriteLine((this.real+complex.real)+"+"+(this.image+complex.image)+"i");

        }
        /// <summary>
        /// 复数的相减
        /// </summary>
        /// <param name="complex">表示要相减的复数</param>
        public void Sub(Complex complex)
        {
            Console.WriteLine((this.real - complex.real) + "+" + (this.image - complex.image)+"i");
 
        }
    }
}
