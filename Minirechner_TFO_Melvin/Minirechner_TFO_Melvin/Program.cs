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
            Addieren(Zahl1, Zahl2);
            Subtrahiere(Zahl1, Zahl2);
            Multiplizieren(Zahl1, Zahl2);
            Dividieren(Zahl1, Zahl2);
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
        static int Addieren(int Nr1, int Nr2)
        {
            Console.WriteLine("Addieren Ergebnis:" + (Nr1 +Nr2));
            return Nr1;
        }
        static int Subtrahiere(int Nr1, int Nr2)
        {
            Console.WriteLine("Subtrahieren Ergebnis:" + (Nr1 - Nr2));
            return Nr1;
        }
        static int Multiplizieren(int Nr1, int Nr2)
        {
            Console.WriteLine("Multiplizieren Ergebnis:" + (Nr1 * Nr2));
            return Nr1;
        }
        static int Dividieren(int Nr1, int Nr2) {
            Console.WriteLine("Dividieren Ergebnis:" + (Nr1 / Nr2));
            return Nr1;
        }
    }
}
