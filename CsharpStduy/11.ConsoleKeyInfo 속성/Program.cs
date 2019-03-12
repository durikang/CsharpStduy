using System;
using System.Threading;
namespace _11.ConsoleKeyInfo_속성
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo KeyInfo;
            /*
            while (true)
            {
                KeyInfo = Console.ReadKey(true);
                if (KeyInfo.Key == ConsoleKey.Backspace)
                {
                    System.Console.Clear();
                    Console.WriteLine("초기화를 완료 하였습니다!");
                    Thread.Sleep(1000);
                    System.Console.Clear();

                }
                else
                {
                    Console.Write($"{KeyInfo.KeyChar}이(가) 눌렸다.");
                    
                }

                if (KeyInfo.Key == ConsoleKey.Escape)
                {
                    System.Console.Clear();
                    Console.WriteLine("종료 키를 누르셨습니다. 종료 합니다.");
                    break;
                }
            }
                */
            /*
             do
        {
            KeyInfo = Console.ReadKey(true);
            if (KeyInfo.KeyChar == 'a')
                Console.WriteLine("a가 눌렸다.");
            else if(KeyInfo.KeyChar =='A')
                Console.WriteLine("A가 눌렸다.");

        } while (KeyInfo.Key != ConsoleKey.Escape);
        */



        }
    }
}
