using System;

namespace _13_3.Struct_예제2_강의용_
{
    public struct MyStruct
    {
        public int kor, eng, math, total;
        public float average;

        public void Compute()//계산.
        {
            total = kor + eng + math;
            average = total / 3.0f;

        }

    }


    class Program
    {
        
        static void Main(string[] args)
        {
            int i = 0;
            MyStruct sbj =new MyStruct();

            sbj.kor = 80;
            sbj.eng = 90;
            sbj.math = 70;
            sbj.Compute();
            Console.WriteLine($"총점 : {sbj.total} 평균 : {sbj.average}");

        }
    }
}
