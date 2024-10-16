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
            Console.WriteLine("Witaj, jak masz na imię? ");

            string imie;
            imie = Console.ReadLine();
            
            Console.WriteLine("W jakim roku się urodziłaś/eś");
            string sRok = Console.ReadLine();
            int rok = Convert.ToInt32(sRok);

            int wiek = DateTime.Now.Year - rok;

            Console.WriteLine($"Witaj {imie}, masz {wiek} lat.");
        }

    }
}
