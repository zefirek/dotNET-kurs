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

            string c = "";
            int d;
            
            Console.WriteLine("Podaj liczbę do sprawdzenia:");
            c = Console.ReadLine();

            Int32.TryParse(c, out d);

            if (d % 2 == 0)
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
