using System;

namespace _23.배열_복사_메서드
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 4 };
            int[] Clonearr = (int[])arr1.Clone();//Clone은 최상위 객체 이기때문에 변환해줄때 데이터 형을 넣어줘야 함.

            Clonearr[2] = 7;
            foreach (int m in arr1)
                Console.Write($"{m} ");
            Console.WriteLine();

            foreach (int m in Clonearr)
                Console.Write($"{m} ");
            Console.WriteLine();


            string[] Days = { "일", "월", "화", "수", "목", "금", "토" };
            string[] DaysClone = (string[])Days.Clone();

            foreach (string str in DaysClone)
                Console.Write($"{str} ");
            Console.WriteLine();



        }
    }
}
