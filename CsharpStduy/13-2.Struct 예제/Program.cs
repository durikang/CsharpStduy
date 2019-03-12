using System;

namespace _13_2.Struct_예제//내가 만들어 본 예제
{
    class Program
    {
        public struct SubjectInfo
        {
            public int kor, eng, math;

            public SubjectInfo(int Inkor,int Ineng,int Inmath)
            {
                kor = Inkor;
                eng = Ineng;
                math = Inmath;
            }

        }
        public struct SubjectInfo2
        {
            public static int  kor, eng, math;
            
        }
        

        static void Main(string[] args)
        {//객체의 생성과 선언을 이용한 구조체의 접근
            SubjectInfo info=new SubjectInfo(98,100,97);
            Console.WriteLine($"국어: {info.kor}영어: {info.eng}수학: {info.math}");

            //객체의 생성만으로 메인 함수에서의 초기화를 이용한 구조체 접근
            SubjectInfo2.kor = 30;
            SubjectInfo2.eng = 72;
            SubjectInfo2.math = 100;
            Console.WriteLine($"국어: {SubjectInfo2.kor}영어: {SubjectInfo2.eng}수학: {SubjectInfo2.math}");





        }
    }
}
