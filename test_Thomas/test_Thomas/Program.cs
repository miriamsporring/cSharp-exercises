using System.Diagnostics;

namespace TestMiriam
{

    class Program
    {
        static void Main(string[] args) 
        { 
            int total = 0;
            int times = 0;
            do
            {
                Console.WriteLine("Skriv in ett tal: ");
                int tal = Convert.ToInt32(Console.ReadLine());
                total += tal;
                times++;
                Console.WriteLine($"total= {total}");

            } while (total < 20);
            Console.WriteLine($"Grattis, det tog {times} försök innan du kom upp i 20 ;)");
            Console.ReadLine();
        }

    }

}