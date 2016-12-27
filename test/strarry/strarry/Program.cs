using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace strarry
{
    class Program
    {
        delegate  void  D(int  i);
              public static void Main()
                {
                 // D d1 = new D(R);
                 // d1(12);
                  int[] num = new int[] { 1, 3, 5 };
                  ArrayList arr = new ArrayList();
                  for (int i = 0; i < num.Length; i++)
                  { arr.Add(num[i]); }
                  arr.Insert(1, 4);
                  foreach(int str in arr)
                  {
                      Console.WriteLine(str);
                  }


                }
                  public static void R(int  t)
                   {	    V(21);		}
                  public static void V(int  i)
                  {Console.WriteLine(i.ToString());	
						Console.ReadLine();
    }
      			

    }
}
