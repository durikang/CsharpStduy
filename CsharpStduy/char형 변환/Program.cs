using System;

namespace char형_변환
{
    class Program
    {
        static void Main(string[] args)
        {
            char Mun = '7';//문자 7
            int num = Mun;//문자 7을 int형으로 형변환해서 55가 됨.
            num += 1;//55+1=56
            Console.WriteLine("Mun ={0}\n문자 상수값 ={1}\n유니코드 문자={2}",(int)Mun,num,(char)num);
            Mun =(char)num;//숫자형태인 num을 (char)로 형변환 해준 후 Mun을 넣어줌.
            Console.WriteLine(Mun);

        }
    }
}
