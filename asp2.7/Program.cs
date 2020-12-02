using System;

namespace asp2._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 5;

            if (a == b)
            {
                Console.WriteLine($"{a} i {b} są sobie równe");
            }

            int c = 15;

            if (c % 2 == 0)
            {
                Console.WriteLine($"\n\r{c} jest liczbą parzystą");
            }
            else
            {
                Console.WriteLine($"\n\r{c} jest liczbą nieparzystą");
            }

        }
    }
}
