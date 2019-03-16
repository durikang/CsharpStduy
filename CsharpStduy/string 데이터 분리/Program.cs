using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_데이터_분리
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.splt의 사용
            var str = "국어: 90 영어: 100 수학: 70";
            string[] str_Element = str.Split(new char[] { ' ' });//' '을 기준으로 문자열을 나누겠다.
            var kor = int.Parse(str_Element[1]);
            var eng = int.Parse(str_Element[3]);
            var math = int.Parse(str_Element[5]);
            var total = kor + eng + math;
            var average = total / 3.0f;


            Console.WriteLine($"국어: {kor}영어: {eng}수학: {math}총점: {total}평균: {Math.Round(average)}");


        }
    }
}
