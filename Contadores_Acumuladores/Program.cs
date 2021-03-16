using System;

namespace Contadores_Acumuladores
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Console.Write("Given n = ");
            n = Int32.Parse(Console.ReadLine());
            int reduce = n;

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < reduce; j++)
                {
                    Console.Write($"{n - j} ");
                }
                Console.WriteLine("");
                reduce--;
            }
        }
    }
}
