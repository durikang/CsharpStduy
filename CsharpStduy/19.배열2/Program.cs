using System;

namespace _19.배열2
{//2차원 배열
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr1 = new int[2, 2];
            arr1[0, 0] = 1;
            arr1[0, 1] = 2;
            arr1[1, 0] = 3;
            arr1[1, 1] = 4;

            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    Console.Write(arr1[i, j] + " ");
            Console.WriteLine();

            int[,] arr2 = { { 1, 2 }, { 3, 4 } };
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    Console.Write(arr2[i, j] + " ");
            Console.WriteLine();

            string[,,] strarry = { { { "ab", "cd" }, { "ef","gh"} },
                                    {{"ij","kl"},{"mn","op"} }};

            foreach(string m in strarry)
            {
                Console.Write($"{m} ");
            }Console.WriteLine();
           // Console.WriteLine(strarry.Length);

        }
    }
}
