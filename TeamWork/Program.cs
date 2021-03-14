using System;

namespace TeamWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0;

            Console.WriteLine("Write the first integer value");
            a = Int32.Parse(Console.ReadLine());

             Console.WriteLine("Write the second integer value");
            b = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"Subtracting {a} - {b} equals {AddNumbers(a, b)}");

        }    static int AddNumbers( int a, int b)
        {
            return a - b;
        }
    }  
}

//Marcela: función creada desde segunda branch
