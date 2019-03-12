using System;

namespace _14.열거형
{
    enum Days {  sun =1,mon,tue,wed,thu,fri,sat};
    enum ex :byte {  sun =1,mon,tue,wed,thu,fri,sat};

    class Program
    {
        static void Main(string[] args)
        {
            int nValue = (int)Days.mon;//-열거형 변수가 아닌 변수에 열거형 값을 대입할 때는 데이터형을 명시할 것.
            byte nValue2 = (byte)ex.mon;//-열거형 변수가 아닌 변수에 열거형 값을 대입할 때는 데이터형을 명시할 것.
            Days day = Days.mon;
            Console.WriteLine($"enum 값: {nValue} {day}");



        }
    }
}
