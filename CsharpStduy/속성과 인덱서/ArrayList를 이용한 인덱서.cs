using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 속성과_인덱서
{
    class A
    {
        ArrayList list = new ArrayList();


        public string this[int index]
        {
            get
            {//인덱서가 0부터 시작하기 때문에
                if (index >= 0 && index < list.Count)
                    return (string)list[index];
                else
                    return null;
            }
            set
            {//
                if (index >= 0 && index < list.Count)
                    list[index] = value;
                else if (index == list.Count)
                    list.Add(value);

            }

        }
        /*
        public void Print()
        {
            foreach(string str in list)
            {
                Console.Write($"{str} ");
            }Console.WriteLine();


        }
        */

    }





    class 인덱서_사용
    {//컬렉션 AarryList
        public static void Main(string[] args)
        {
            A test = new A();
            test[0] = "A";
            test[1] = "B";
            test[2] = "C";
            test[3] = "D";




        }

    }
}
