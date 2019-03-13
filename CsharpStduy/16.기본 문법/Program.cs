using System;


namespace _16.기본_문법
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = false;

            if (!a)
            {
                a = true;
            }

            if (a)
            {
                Console.WriteLine($"a는 {a}입니다.");   
            }

            int b = 123;
            Console.WriteLine(b + "what");

            string[] str = Console.ReadLine().Split(' ');
            for(int i = 0; i < str.Length; i++)
            {
                Console.WriteLine(str[i]);

            }

        }
    }
}
