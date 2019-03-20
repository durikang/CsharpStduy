using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 속성과_인덱서
{
    public class Data
    {
        private string str;
        public static int a;

        public string Str
        {
            get
            {
                return str;
            }
            set
            {
                str = value;
            }

        }
        public int A
        {
            get
            {
                return a;
            }
            set {
                a = value;
            }

        }


    }


    class Program
    {
        static void Main(string[] args)
        {
            Data dt = new Data();
            dt.Str = "hello world!";
            dt.A = 10;
            Console.WriteLine(dt.Str);
            Console.WriteLine(dt.A);


        }
    }
}
