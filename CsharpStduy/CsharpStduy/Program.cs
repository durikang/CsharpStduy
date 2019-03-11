using System;

namespace CsharpStduy
{

    

    class Program
    {
        static bool BoolVar;//메인에서 BoolVar값을 사용하기 위하여 static으로 선언해 줘야함.
                            //기본값은 false이다.
        static void Main(string[] args)//CLR에서의 약속이기 때문에 Main함수에서는 반듯이 static으로 선언해 줘야 한다.
        {
            bool LocalBoolVar = true;
            Console.WriteLine("전역 변수의 bool:{0}\n지역 변수의 bool:{1}", BoolVar, LocalBoolVar);


        }
    }
}
