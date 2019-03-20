using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 클래스
{
    class MyClass//힙영역에 클래스가 올라감.
    {


        public int val;
        public static string str;
        public MyClass()
        {
        }

        public MyClass(int Val)//생성자
        {
            this.val = Val;
        }

        public void Print()
        {
            Console.WriteLine($"{str} {val}");

        }

        ~MyClass()
        {
            Console.WriteLine("소멸자 호출");
        }


    }



    class Program
    {
        static string STR ="HEY !";

        static void Main(string[] args)
        {
            MyClass test = new MyClass();
            MyClass RefClass =test;//클래스의 참조

            test.val = 10;
            Console.WriteLine(RefClass.val);

            //프로그램이 끝낫음으로 가비지 컬렉터가 메모리를 회수함.

        }
    }
}
