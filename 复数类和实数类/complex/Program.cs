using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace complex
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex a = new Complex();
            Complex b = new Complex(2,5);
            Console.WriteLine("复数类:"+(a+b).ToString());
            RealComplex c = new RealComplex();
            RealComplex d = new RealComplex(5);
            Console.WriteLine("实数类："+(c + d).ToString());
        }
        /// <summary>
        /// 自定义了一个复数类
        /// </summary>
        public class Complex
        { 
            private double real, image;
            public Complex(double real, double image)//有参构造函数
            {
                this.real = real;
                this.image = image;
 
            }
            public Complex()//无参构造函数
            {
                this.real = 0;
                this.image = 0;
            }
            public override string ToString()
            {

                if (this.image == 0 && this.real == 0)
                {
                    return "";
                }
                else if (this.real == 0)//实部位0
                {
                    return image+"i";
                   // Console.WriteLine(image+"i");
                }
                else if (this.image == 0)//虚部为0
                {
                    return real.ToString();;
                    //Console.WriteLine(real);
                }
                else //实部虚部都有值
                {
                    return real + "+" + image + "i";
                    //Console.WriteLine(real+"+"+image+"i");
                }
                
                
            }
            public double getReaddata()
            {
                return this.real;
            }
            public double getImagedata()
            {
                return this.image;
            }
            public Complex complexAdd(Complex a)// 复数类的加法
            {
                return new Complex((this.real + a.real), (this.image + a.image));
 
            }
            public Complex complexSub(Complex a)
            {
                return new Complex((this.real - a.real), (this.image - a.image));
            }
            public Complex complexMulti(Complex a)
            {
                return new Complex((this.real*real),(this.image*image));
 
            }
            public static Complex operator+(Complex a,Complex b)//+号运算符重载（+）
            {
                return new Complex((a.real + b.real), (a.image + b.image));

            }
            public static Complex operator-(Complex a, Complex b)//减号运算符重载（-）
            {
                return new Complex((a.real - b.real), (a.image - b.image));
            }
            public static Complex operator *(Complex a, Complex b)//乘号运算符重载（*）
            {
                return new Complex((a.real * b.real), (a.image * b.image));
            }
            public static Complex operator++(Complex a)//自增运算符重载（++）

            {
                return new Complex(++a.real, ++a.image);

            }
            public static Complex operator --(Complex a)//自减运算符重载（-）
            {
                return new Complex(--a.real, --a.image);
            }

        }
        /// <summary>
        /// 实数类继承自复数类
        /// </summary>
        public class RealComplex : Complex
        {
            public RealComplex():base(0,0)
            {
               
            }
            public RealComplex(double a):base(a,0)
            {
                
            }
 
        }
    }
}
