using System;
using System.IO;

namespace _24_2.FileStream과StreamReader_사용법
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            FileStream fs = new FileStream("text.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            int value = int.Parse(sr.ReadLine());
            float value2 = float.Parse(sr.ReadLine());
            string str1 = sr.ReadLine();
            sr.Close();
            Console.WriteLine($"{value} {value2} {str1}");

            
             FileStream fs = new FileStream("text.txt", FileMode.Open, FileAccess.Read);

            using (StreamReader sr = new StreamReader(fs))//close함수가 필요 없음
            {
                int value = int.Parse(sr.ReadLine());
                float value2 = float.Parse(sr.ReadLine());
                string str1 = sr.ReadLine();
                Console.WriteLine($"{value} {value2} {str1}");


            }

             */
            //streamReader만을 사용한 예제
            StreamReader sr = new StreamReader("text.txt");
            int value=int.Parse(sr.ReadLine());
            float value2=float.Parse(sr.ReadLine());
            string str1=sr.ReadLine();
            sr.Close();
            Console.WriteLine($"{value} {value2} {str1}");


        }
    }
}
