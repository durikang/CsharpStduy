using System;

namespace _06.nullable_형
{
    class Program
    {
        static void Main(string[] args)
        {
            int? var1=1;//true
            int? var_1 = null;//false
            //bool? var2 = null;

            if (var1.HasValue)
            {
                Console.WriteLine("옳바른 값.");
            }
            else
            {
                Console.WriteLine("null 값");
            }

            Console.WriteLine("null : {0}", var_1);



        }
    }
}
