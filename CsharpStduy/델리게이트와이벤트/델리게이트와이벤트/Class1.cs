using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 델리게이트와이벤트
{
    delegate void DelegateType();
    
    class A
    {
        public void PrintA()
        {
            Console.WriteLine("PrintA");
        }
        public void PrintB()
        {
            Console.WriteLine("PrintB");
        }
    }

    class Program
    {
        static void Main()
        {
            A test = new A();
            DelegateType delfunc = test.PrintA;
            delfunc += test.PrintB;
            delfunc();
            delfunc -= test.PrintA;
            delfunc();

        }

    }
}
