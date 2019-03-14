using System;

namespace _20.가변배열
{
    class Program
    {
        static void Main(string[] args)
        {

            int[][] arr1 = new int[2][];
            arr1[0] = new int[3] { 1, 2, 3 };
            arr1[1] = new int[3] { 4, 5, 6 };
            
            foreach(int[] ia in arr1)
            {
                foreach(int i in ia)
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();

            int[][] arr2 =
            {
                new int[2]{1,2},
                new int[3]{3,4,5}
            };
            foreach (int[] ia in arr2)
            {
                foreach (int i in ia)
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();

            int[][][] arr3 =
            {
                new int[2][]

            };

            arr3[0][0] = new int[2] { 1, 2 };
            arr3[0][1] = new int[2] { 3, 4 };
            //1면2행2열씩2개

            foreach(int[][] ia in arr3)
            {
                foreach(int[] ib in ia)
                {
                    foreach(int ic in ib)
                    {
                        Console.Write($"{ic} ");
                    }
                }
            }
            Console.WriteLine();



        }
    }
}
