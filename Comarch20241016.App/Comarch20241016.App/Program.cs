/*
 I jest to komentarz
 wielolinijkowy. 
 */

using System;

namespace Comarch20241016.App
{
    internal class Program
    {

        /// <summary>
        /// Punkt startowy aplikacji
        /// </summary>
        /// <param name="args">Parametry startowe aplikacji.</param>
        /// <returns></returns>
        static void Main(string[] args)
        {
            Console.WriteLine("KALKULATOR 1.0");
            Console.WriteLine("  1. Dodawanie");
            Console.WriteLine("  2. Odejmowanie");

            Console.Write("Podaj pozycję menu: ");

            bool czyKonwersjaSieUdala = int.TryParse(Console.ReadLine(), out int wybor);

            if (czyKonwersjaSieUdala)
            {
                int x,y;
                Console.Write("Podaj X: ");
                x = int.Parse(Console.ReadLine());

                Console.Write("Podaj Y: ");
                y = int.Parse(Console.ReadLine());


                switch (wybor)
                {
                    case 1:
                        Console.WriteLine($"Wynik dodawania {x} + {y} to {x + y}");
                        break;
                    case 2:
                        Console.WriteLine($"Wynik odejmowania {x} - {y} to {x - y}");
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wprowadzono nieprawidłową pozycję menu!");
                        Console.ResetColor();
                        break;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wprowadzono nieprawidłową wartość!");
                Console.ResetColor();
            }
        }

    }
}
