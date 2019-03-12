using System;


namespace _12.ReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] Subject =new float[3];
            float Total = 0;
            float average = 0f;
            int i=0;
            
            do
            {
                if (i == 0)
                    Console.WriteLine("국어 점수를 입력해 주세요!");
                else if (i == 1)
                    Console.WriteLine("영어 점수를 입력해 주세요!");
                else
                    Console.WriteLine("수학 점수를 입력해 주세요!");
                Subject[i] = int.Parse(Console.ReadLine());
                Total += Subject[i];
                i++;

            } while (i != 3);
            i = 0;
            for(i = 0; i < 3; i++)
            {
                if (i == 0)
                    Console.WriteLine($"국어 점수는 {Subject[i]:f1}입니다.");
                else if(i==1)
                    Console.WriteLine($"영어 점수는 {Subject[i]:f1}입니다.");
                else
                    Console.WriteLine($"수학 점수는 {Subject[i]:f1}입니다.");
            }

            average = Total / 3.0f;
            Console.WriteLine($"평균은 {average:F1}입니다.");



        }
    }
}
