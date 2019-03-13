using System;

namespace _18.배열1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3 };

            foreach (int i in arr)
                Console.Write($"{i} ");
            Console.WriteLine();

            string[] days = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

            foreach (string str in days)
                Console.Write($"{str} ");
            Console.WriteLine();
        }
    }
}
