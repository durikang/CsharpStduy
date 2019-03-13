using System;
using System.Linq;
using System.Text;
using System.Collections;
//using System.Collections;

namespace 제어문
{
    class repeat
    {
        public struct MyStruct
        {
            public static int a = 10;
            public int b;
        }


        public static void ex()
        {
            int[] arr = new int[] { 1, 2, 3, 4 };
            //int cnt = 0;
            foreach (int i in arr)//읽기 전용이기 때문에 i는 변경이 불가능하다.
            {
                Console.WriteLine($"arr : {i}");
            }
        }
        public static void List()
        {
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            foreach (int m in list)
            {
                Console.WriteLine($"List : {m}");
            }

        }

        public static void exList()
        {
            ArrayList myAL = new ArrayList();
            myAL.Add("Hello");
            myAL.Add("World");
            myAL.Add("!");

            Console.WriteLine("myAL");
            Console.WriteLine($"Count:{myAL.Count}");
            Console.WriteLine($"Capacidy:{myAL.Capacity}");
            Console.WriteLine($"    Values:");
            PrintValues(myAL);

        }
        public static void PrintValues(IEnumerable myList)
        {
            foreach (Object obj in myList)
            {
                Console.Write($"     {obj}");
            }
            Console.WriteLine();


        }
        

    }


    class Program :repeat
    {
        static void Main(string[] args)
        {
            //int nNum = 10;
            /*
            if (nNum!=0)
            {
                Console.WriteLine("Hello world!");

            }
            else
            {
                Console.WriteLine("C# Programing!");
            }

            int a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 0:Console.WriteLine("Zero");break;
                case 1:Console.WriteLine("One"); break;

            }
            string b = "hello world";
            switch (b)
            {
                case "hello world": Console.WriteLine("Zero"); break;
                //case 1: Console.WriteLine("One"); break;

            }
            char[] value=new char[1];
            value[0]=char.Parse(Console.ReadLine());
            switch (value[0])
            {
                case ' ': Console.WriteLine("Space"); break;
                case 'a': Console.WriteLine("a"); break;

            }
            */
            int res = 0;
            res=MyStruct.a;
            Console.WriteLine(res);
            ex();//foreach 예제문
            List();//List를 이용한 예제문      
            exList();//MSDN에있는 예제문


        }
    }
}
