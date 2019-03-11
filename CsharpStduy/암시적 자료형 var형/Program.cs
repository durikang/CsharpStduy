using System;

namespace 암시적_자료형_var형
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             var형 변수에 데이터가 분명한 값으로 선언과 초기화를 한 후에 두 값을
             더한 결과를 출력해 보자.
             */

            var a = 10;//int형으로 쓰임
            var b = 10;//int형으로 쓰임
            var res = 0;//int형으로 쓰임
            res = a + b;//10+10=20
            Console.WriteLine(res);//결과 20
            var value1 = 3.14f;//float형
            float value2 = 10.12f;
            float sum = value1 + value2;

            Console.WriteLine("{0} + {1:f1}= {2}", value1, value2, sum);
            //3.14 + 10.0({1:f1}이므로 소수 첫째 자리까지 반올림하여 표현)=13.14
        }
    }
}
