using System;

namespace Is연산자
{
    class Program
    {
        static void Main(string[] args)
        {

            int nValue = 10;
            if (nValue is float)
            {
                Console.WriteLine("호환 됨");
            }
            else
                Console.WriteLine("호환이 안됨");
            
             if(nValue is object)//int를 boxing 할 수 있겟는가?(호환가능한가?)
            {
                Console.WriteLine("호환 됨");
            }
            else
                Console.WriteLine("호환이 안됨");
             
            object obj = nValue;
            if(obj is int)//object는 int로 unboxing이 가능한가?
            {
                Console.WriteLine("호환 됨");
            }
            else
                Console.WriteLine("호환이 안됨");

             

        }
    }
}
