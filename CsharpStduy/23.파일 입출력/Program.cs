using System;
using System.IO;

namespace _23.파일_입출력//상당히 중요.
{//1.FileStrea과 StreamWriter 사용
    class Program
    {
        static void Main(string[] args)
        {
            //1.스트림

            //FileStream fs = new FileStream("test.txt", FileMode.Create);

            /*StreamWriter sw = new StreamWriter(fs);
            sw.Close();
            
            using (StreamWriter sw = new StreamWriter(fs){


             }
             */

           
            int value = 12;
            float value2 = 3.14f;
            string str1 = "Hello World!";

            FileStream fs = new FileStream("text.txt", FileMode.Create);
            /*
            //1.Write(),WriteLine()
            StreamWriter sw = new StreamWriter(fs);
              sw.WriteLine($"{value} ");
              sw.WriteLine($"{value2} ");
              sw.WriteLine($"{str1} ");
              sw.Close();
             */

            //using 문을 사용한 코드
            using (StreamWriter sw2 = new StreamWriter(fs))
            {
                sw2.WriteLine($"{value} ");
                sw2.WriteLine($"{value2} ");
                sw2.WriteLine($"{str1} ");

            }


            //StreamWriter만 사용한 코드
            StreamWriter sw3 = new StreamWriter("Duri.txt");
            sw3.WriteLine($"{value} ");
            sw3.WriteLine($"{value2} ");
            sw3.WriteLine($"{str1} ");
            sw3.Close();


        }
    }
}
