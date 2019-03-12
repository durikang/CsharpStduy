using System;

namespace Struct_2
{

    public struct MyStruct
    {
        public int Age;
    }

    class MyClass
    {
        public int Age;

    }





    class Program
    {
        static void Main(string[] args)
        {


            MyStruct test1 = new MyStruct();
            test1.Age = 12;
            MyStruct test2 = test1;// '='값 형식을 의미 
            test2.Age = 24;
            Console.WriteLine($"{test1.Age} {test2.Age}");

            MyClass test3 = new MyClass();
            test3.Age = 12;
            MyClass test4 = test3;// '=' 참조 형식을 의미
            test4.Age = 24;
            Console.WriteLine($"{test3.Age} {test4.Age}");



        }
    }
}
