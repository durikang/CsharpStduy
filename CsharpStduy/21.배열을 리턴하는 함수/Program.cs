using System;

namespace _21.배열을_리턴하는_함수
{
    class Program
    {
        static int[] CreateArray1(int nsize)
        {
            int[] arry1 = new int[nsize];
            for(int i = 0; i < arry1.Length; i++)
            {
                arry1[i] = i;
            }

            return arry1;
        }
        static int[,] CreateArray2(int nRow,int nCol)
        {
            int idx = 0;
            int[,] arry2 = new int[nRow,nCol];
            for (int i = 0; i < nRow; i++)
                for (int j = 0; j < nCol; j++)
                    arry2[i, j] = idx++;
            

            return arry2;
        }

        static void Main(string[] args)
        {
            int[] arr1;
            int[,] arr2;

            arr1 = CreateArray1(5);
            arr2 = CreateArray2(2,3);

            for(int i = 0; i < arr1.Length; i++)
                Console.Write($"{arr1[i]} ");
            Console.WriteLine();


            
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 3; j++)
                Console.Write($"{arr2[i, j] } ");
            Console.WriteLine();
            

        }


    }
}
