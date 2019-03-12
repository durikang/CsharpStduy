using System;

namespace _10.박싱과_언박싱
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 123;
            object obj = m;//데이터 형을 최상위 오브젝트로 변환하여 힙(heap메모리)에 저장
            Console.WriteLine(obj);



            int n = (int)obj;//힙에 저장된 형식을 다시 원래의 형식으로 변환.

            Console.WriteLine(n);

            int i = 123;
            object o = i;
            i = 456;
            Console.WriteLine($"{(int)o} {i}");


        }
    }
}
