using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10강.배열_인덱서_정리
{
    class Program
    {
        static void Main(string[] args)
        {//배열/객체배열/속성/인덱서 비교

            int[,] arr = new int[9, 9];

            for(int i=0;i<9;i++)
            {
                for (int j = 9; j-i >0; j--)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }





        }
    }
}
