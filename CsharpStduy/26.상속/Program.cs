using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26.상속//override와 overload 사용의 예
{
    class A
    {
        public void print() { Console.WriteLine("Hello"); }
        public void print(int num)
        {
            Console.WriteLine(num);
        }
        public float print(int num,float pi)
        {
            Console.WriteLine($"{num} {pi}");
            return pi;
        }
        public virtual void Print()
        {
            Console.WriteLine("A Print");

        }

    }
    class B :A
    {
        public override void Print()
        {
            Console.WriteLine("B Print");

        }

        
    }


    class Program
    {
        static void Main(string[] args)
        {
            //B test = new B();
            //test.Print();

            A test1 =new A();
            //test1.Print();
            test1.print();
            test1.print(100);
            test1.print(20, 3.14f);
            
        }
    }
}
