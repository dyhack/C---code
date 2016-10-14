using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 我的Csharp作业
{
    class Rectangle
    {
        private  double Xleft, Yleft;
        private  double Xright, Yright;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="X">矩形的长</param>
        /// <param name="Y">矩形的宽</param>
        
        public Rectangle(double Xleft,double Yleft,double Xright,double Yright)//
        {
            this.Xleft = Xleft;
            this.Yleft = Yleft;
            this.Xright = Xright;
            this.Yright = Yright;
 
        }
        public Rectangle()
        {
            
        }
        
        public  static Rectangle operator --(Rectangle temp)
        {
            
            return new Rectangle(temp.Xleft,temp.Yleft,temp.Xright-1,temp.Yright-1);
        }

        public static Rectangle operator +(Rectangle a, Rectangle b)
        {
            double[]X={a.Xleft,a.Xright,b.Xleft,b.Xright};
            double[]Y={a.Yleft, a.Yright,b.Yleft,b.Yright };
            double minx1 = a.Xleft, miny1 = a.Yleft, maxx2 = a.Xleft, maxy2 = a.Yleft;
            for (int i = 0; i <= 3; i++)
            {
                minx1=FindminX(minx1,X[i]);
                miny1=FindminY(miny1, Y[i]);
                maxx2=FindmaxX(maxx2,X[i]);
                maxy2=FindmaxY(maxy2,Y[i]);
            }
           
            return new Rectangle(minx1, miny1, maxx2, maxy2);

  
        }
        public static  double FindmaxX(double x1,double x2)//查找最大的X的值
        {
            return x1 >= x2 ? x1 : x2;

        }
        public static double FindmaxY(double y1,double y2)
        {
            return y1 >= y2 ? y1 : y2;
        }
        public static double FindminX(double x1,double x2)
        {
            return x1 <= x2 ? x1 : x2;
        }
        public static  double FindminY(double y1,double y2)
        {
            return y1 <= y2 ? y1 : y2;
        }
        public double RectangleArea()
        {
            return Math.Abs((this.Xright - this.Xleft)) * Math.Abs((this.Yright - this.Yleft));
        }
        public double RectangleLength()
        {
            return (Math.Abs((this.Xright - this.Xleft)) + Math.Abs((this.Yright - this.Yleft))) * 2;
        }
       public override string  ToString()
       {
           
           return "矩形的长是"+Math.Abs((this.Xright-this.Xleft))+"宽是:"+Math.Abs((this.Yright-this.Yleft));
       }
        static void Main(string[] args)
        {
            Rectangle a = new Rectangle();
            Rectangle b = new Rectangle(-11, 22,-33,44);
            Rectangle c = new Rectangle(22,33,55,77);
            c=b + c;
            Console.WriteLine(c.ToString());
            Console.WriteLine(c.RectangleArea());
            Console.WriteLine((a+b).ToString());
            Console.WriteLine((b + c).ToString());
        }
    }
}
