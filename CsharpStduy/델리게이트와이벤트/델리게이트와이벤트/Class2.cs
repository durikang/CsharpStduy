using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 델리게이트와이벤트
{
    delegate void DelegateType(string message);
    class A
    {
        public event DelegateType EventHandler;
        public void Func(string message)
        {
            EventHandler(message);
        }


    }
    class B
    {
       public void PrintA(string message)
        {
            Console.WriteLine(message);
        }
        public void PrintB(string message)
        {
            Console.WriteLine(message);
        }

    }

    class Class2
    {
        public static void Main()
        {

            A test1 = new A();
            B test2 = new B();

            test1.EventHandler += new DelegateType(test2.PrintA);
            test1.EventHandler += new DelegateType(test2.PrintB);
            test1.Func("Good!!");
            test1.EventHandler -= test2.PrintB;
            test1.Func("Hi~~0");
            test1.EventHandler -= test2.PrintA;

            test1.EventHandler += test2.PrintA;
            test1.EventHandler += test2.PrintB;

            test1.Func("ho00");
        }


    }
}
