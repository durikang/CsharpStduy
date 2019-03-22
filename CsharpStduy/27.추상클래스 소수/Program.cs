using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27.추상클래스_소수
{
    abstract class A
    {
        int number = 3;
        public abstract void Print();//미구현된 상태를 자식 클래스인 b가 구현 해야됨.
        public void PrintNumber()
        {
            Console.WriteLine(number);

        }
    }
    class B : A
    {
        public override void Print()
        {
            Console.WriteLine("abstract class");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            B test = new B();
            test.Print();
            test.PrintNumber();
        }

    }
}
