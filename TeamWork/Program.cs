using System;

namespace TeamWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 0, d = 0;

            Console.WriteLine("Write number multiplying:");
            c = Int32.Parse(Console.ReadLine());

             Console.WriteLine("Write multiplier number:");
            d = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"Multiplying {c} * {d} equals {AddNumbers(c, d)}");

        }    static int AddNumbers( int c, int d)
        {
            return c * d;
        }
    }  
}

//Modificacion de resta a multiplicación Terminada.
