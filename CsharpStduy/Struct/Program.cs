using System;


namespace Struct
{

    class Program
    {//소스 3-15 구조체 안의 const 또는 static 변수에 대해서만 선언과 동시에 초기화하는 예이다.
        public struct Mystruct
        {
            //const 와 static은 정적변수 이기 때문에 자동으로 선언이 됀다.

            public const float PI = 3.14f;
            //public static int Age = 12;
            public int Age;
            //static으로 안만들어 줄 경우 main함수에서 해당 함수를 사용 하기 위해선 메인 함수에다가 클래스를 선언해주고 초기화를 해줘야 한다.
            //public int va;

            public Mystruct(int InAge)
            {
                Age = InAge;

            }


        }

        public struct Mystruct2
        {
            public int Age;

        }

        

        static void Main(string[] args)
        {
            //Mystruct mr = new Mystruct(); //구조체를 생성 할 경우 매개변수값이 기본값으로 초기화가 이루어 진다.
            Mystruct mr;
            //생성된 객체 내에서의 매소드는 기본값으로 초기화 되어 있다.
            Mystruct mr2 =new Mystruct();
            Mystruct mr3 =new Mystruct(12);

            //Console.WriteLine($"{Mystruct.PI} {Mystruct.Age}");

            mr.Age = 10;
            Console.WriteLine($"{mr.Age}");
            Console.WriteLine($"{mr2.Age}");
            Console.WriteLine($"{mr3.Age}");
            Console.WriteLine($"{Mystruct.PI}");
            //mr.va = 10;//
            //Console.WriteLine($"{mr.va}");


            //구조체를 같은 구조체에 대입하게 되면 값이 복사 된다.
            Mystruct2 ar1, ar2;
            ar2.Age = 25;
            ar1 = ar2;

            Console.WriteLine($"{ar1.Age}");

            //-구조체는 값 형식이고 클래스는 참조 형식이다.

        }
    }
}
