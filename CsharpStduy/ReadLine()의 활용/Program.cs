using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadLine__의_활용
{

    class Program
    {
        struct Grade
        {
            public int kor, eng, math, total;
            public float average;
            
        };
        

        static void Main(string[] args)
        {
            string str;
            Console.WriteLine("성적 처리를 위한 학생 수를 입력해 주세요 :");
            int nCount = int.Parse(Console.ReadLine());
            Console.WriteLine("국 영 수 순으로 입력해 주세요");
            Grade[] grade = new Grade[nCount];
            FileStream fs = new FileStream("Student's Grade.txt",FileMode.Create);

            for(int i = 0; i < nCount; i++)
            {
                grade[i].kor = int.Parse(Console.ReadLine());
                grade[i].eng = int.Parse(Console.ReadLine());
                grade[i].math = int.Parse(Console.ReadLine());
                grade[i].total += grade[i].kor + grade[i].eng + grade[i].math;
                grade[i].average = grade[i].total / 3;
            }

            using (StreamWriter sw =new StreamWriter(fs))
            {

            }


        }
    }
}
