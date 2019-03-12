using System;

namespace _15.값_형식
{

    class Program
    {
        static void Main(string[] args)
        {
            int a = 12;
            int b = new int();//초기화 기본값 0
            Console.WriteLine($"기본 데이터 형 int: {a} 값의 생성과 선언 초기화 :{b}");

            int[] arr1 = { 1, 2, 3 };
            int[] Refarr;//참조형 배열 변수
            Refarr = arr1;//Refarr에 arr1의 주소가 복사 됨.
            Refarr[1] = 20;//arr[1]의 값이 20으로 바뀜. ->현재 Refarr의 주소는 arr1의 주소를 갖고 있음
            Console.WriteLine($"{arr1[0]} {arr1[1]} {arr1[2]}");

          

        }
    }
}
