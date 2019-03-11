using System;

namespace _08.변환
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int a = 10;
            Console.WriteLine("int 형: {0}",a);//int형 10이 출력
            string str=a.ToString();//int를 string으로 형변환

            Console.WriteLine("string 형: {0}", str);//문자형 10이 출력
            int b;
            b=Convert.ToInt32(str);//문자형 10을 int형으로 변환
            Console.WriteLine("int 형: {0}", b);
            float c;
            c = Convert.ToSingle(b);//int형을 float으로 변환
            Console.WriteLine("int 형: {0}", c);
            */
            ///////////////위의 예제는 내가 만들어 봄
            int value1 = 127;
            string str1 = value1.ToString();
            Console.WriteLine(str1);

            int value2 = Convert.ToInt32(str1);
            Console.WriteLine(value2);

            string str2 = "3.14";
            float value3 = float.Parse(str2);
            Console.WriteLine(value3);


        }
    }
}
