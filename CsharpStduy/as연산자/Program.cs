using System;

namespace as연산자
{
    class A
    {

    }
    class B
    {


    }


    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "123";
            object obj = str1;
            string str2 = obj as string;//obj를 string으로 형변환이 가능한가?
            Console.WriteLine(str2);

            

            A test1 = new A();
            object obj1 = test1;
            B test2 = obj1 as B;//객체끼리는 형변환이 불가능하다.
            if (test2 == null)
                Console.WriteLine("형변환 실패");
            else
                Console.WriteLine("형변환 성공");



        }
    }
}
