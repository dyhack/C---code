using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Version3
{
    abstract class A
    {
        public abstract void Method();
     }
    class B : A
    {
        public override void Method()
        {
            throw new NotImplementedException();
        }
    }
    class C : B
    {
        public override void Method()
        {
            Console.WriteLine("C.Method");
        }
    }
    class VersionControl
    {
        public static void Main()
        {
           
            B b = new C();
            A c = b;
            b.Method();
            c.Method();
            Console.Read();
             
        }
    }
}

   



