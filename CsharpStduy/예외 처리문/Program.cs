using System;

namespace 예외_처리문
{
    class try_catch
    {
        public static void try__catch()
        {
            /*
           //-IndexOutOfRangeException 예제문
           int[] arr ={ 1, 2, 3 };
           try
           {
               arr[3] = 10;

           }
           catch(IndexOutOfRangeException e)
           {
               Console.WriteLine("배열 인덱스 에러 발생");
               Console.WriteLine(e.ToString());
               arr[2] = 10;
           }
           for(int i = 0; i < arr.Length; i++)
           {
               Console.Write($"arr : {arr[i]} ");

           }Console.WriteLine();
           */
            //-try문 안에서 초기화한 변수를 try문 밖에서 사용할 수 없다. 아래 예제문
            int m;
            try
            {
                m = 12;
                Console.WriteLine($"try문 출력: {m}");

            }
            catch
            {
                Console.WriteLine("예외 발생");

            }
            //Console.WriteLine($"try문 밖에서 변수 출력 : {m}");//<<-에러 표시;

        }

        public static void try_finally()
        {
            int[] arr = { 1,2,3 };
            try
            {
                Console.WriteLine("try 문에서 예외 발생시킵니다.");
                arr[3] = 10;
            }
            finally
            {
                Console.WriteLine("finally 구문입니다.");

            }
            foreach(var m in arr){
                Console.Write($"{m} ");
            }

        }
        public static void try_finally2()
        {
            int i=0;
            try
            {
                i = 12;
            }
            finally
            {
                i = 100;
                Console.WriteLine($"finally 구문 :{i}");

            }
            i = 200;
                Console.WriteLine($"try finally문 밖에서 실행 i값 :{i} ");
            

        }
        
    }
    

    class Program:try_catch
    {
        //throw 예제 문
        static int GetNumber(int idx) 
        {
            int[] nums = { 300, 600, 900 };
            if (idx >= nums.Length)
            {
                throw new IndexOutOfRangeException();
            }
            return nums[idx];
        }



        static void Main(string[] args)
        {
            // try__catch();
            //try_finally();
            //try_finally2();
            int res = GetNumber(3);
        }
    }
}
