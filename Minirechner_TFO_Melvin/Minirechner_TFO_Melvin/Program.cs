using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minirechner_TFO_Melvin
{

    class Program
    {
        
        static void Main(string[] args)
        {    int Zahl1, Zahl2;
            Titel("Mirechner:");
            Console.WriteLine();
            Console.WriteLine("Geben sie die erste Zahl ein:");
            Zahl1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Geben sie die zweite Zahl ein:");
            Zahl2 = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();
        }
        static void Titel(string Titel) {
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine(Titel);
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("*");
            }
        }

    }
}
