using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 속성과_인덱서
{

    class A
    {

       int[] number = new int[3];
        int total;
        float average;

     
        public int this[int index]
        {
            get
            {
                return number[index];
            }
            set
            {
                number[index] = value;

            }

        }

        public void Print()
        {
            foreach(int i in number)
            {
                Console.Write($"{i} ");
            }Console.WriteLine();
        }
       

    }

    class Indexer2
    {//인덱스 예제

        

        public static void Main(string[] args)
        {
            A test = new A();

            for(int i = 0; i < 3; i++)
            {
                test[i] = int.Parse(Console.ReadLine());
            }

            test.Print();
            
            
          

        }


    }
}
