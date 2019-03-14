using System;

namespace _22.배열의_매서드들
{
    class Program
    {

      

        static void Main(string[] args)
        {
            int[] arr={ 1, 2,3,4 };
            foreach (int ia in arr)
                Console.Write($"{ia} ");
            Console.WriteLine();

            Array.Clear(arr, 0, 3);
            foreach (int ia in arr)
                Console.Write($"{ia} ");
            Console.WriteLine();


            Array.Clear(arr, 0, arr.Length);
            foreach (int ia in arr)
                Console.Write($"{ia} ");
            Console.WriteLine();

            int[] arr2 = { 7, 7,7,7 };

            Array.Copy(arr2, arr, arr.Length);
            foreach (int ia in arr)
                Console.Write($"{ia} ");
            Console.WriteLine();
            



        }
    }
}
