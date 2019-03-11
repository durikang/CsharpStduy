using System;

namespace string형_문제_2개
{
    class Program
    {
        static void Main(string[] args)
        {
            //두 문자열을 합친 후에 합친 문자열과 다섯번째문자를 출력해 보자.
            string str1 = "Hello";
            string str2 = " World";
            string res = str1 + str2;
            Console.WriteLine(res);
            Console.WriteLine(res[4]);

            //문자열의 문자 개수를 Length로 확인해 보자.
            int size = res.Length;
            Console.WriteLine(size);

            if(res =="Hello World")
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);

            }


        }
    }
}
