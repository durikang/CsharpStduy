using System;

namespace null병합_연산자
{
    class Program
    {
        static void Main(string[] args)
        {
            int? x = null;// nullable 형식, null저장 가능
            int y = x ?? -1;//x가 null이면 -1을 y에 대입하고
                            //x가 null이 아니면 x를 y에 대입한다.
            Console.WriteLine(y);

            x = 10;
            y = x ?? -1;
            Console.WriteLine(y);



        }
    }
}
