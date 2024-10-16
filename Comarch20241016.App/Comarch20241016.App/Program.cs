﻿/*
 I jest to komentarz
 wielolinijkowy. 
 */

using System;

namespace Comarch20241016.App
{
    public class Program
    {

        /// <summary>
        /// Punkt startowy aplikacji
        /// </summary>
        /// <param name="args">Parametry startowe aplikacji.</param>
        /// <returns></returns>
        static void Main(string[] args)
        {
            bool czyKontynuowac;
            do
            {
                PokazMenu();

                Console.Write("Podaj pozycję menu: ");

                bool czyKonwersjaSieUdala = int.TryParse(Console.ReadLine(), out int wybor);

                if (czyKonwersjaSieUdala)
                {
                    int x, y;
                    int wynik;

                    switch (wybor)
                    {
                        case 1:
                            PobierzXY(out x, out y);
                            wynik = CalculateAdd(x, y);
                            Console.WriteLine($"Wynik dodawania {x} + {y} to {wynik}");
                            break;
                        case 2:
                            PobierzXY(out x, out y);
                            Console.WriteLine($"Wynik odejmowania {x} - {y} to {x - y}");
                            break;
                        case 4:
                            PobierzXY(out x, out y);
                            try
                            {
                                wynik = CalculateDividy(x, y);
                                Console.WriteLine($"Wynik dzielenia {x} / {y} to {wynik}");
                            }
                            catch (Exception ex)
                            {
                                PokazBlad(ex.Message);
                            }
                            break;
                        case 5:
                            int[] liczby = WczytajTablice();
                            PosortujTablice(liczby);
                            PokazTablice(liczby);
                            break;
                        default:
                            PokazBlad("Wprowadzono nieprawidłową pozycję menu!");
                            break;
                    }
                }
                else
                {
                    PokazBlad("Wprowadzono nieprawidłową wartość!");
                }
                Console.ReadKey();

                Console.Write("Czy chcesz wykonać kolejne działanie? [T|n]");
                ConsoleKeyInfo consoleKey = Console.ReadKey();
                czyKontynuowac = consoleKey.Key != ConsoleKey.N;

            } while (czyKontynuowac);
        }

        private static void PokazTablice(int[] liczby)
        {
            Console.WriteLine($"[{string.Join(", ", liczby)}]");
        }

        private static void PosortujTablice(int[] liczby)
        {
            // Algorytm sortowania bąbelkowego
            int n = liczby.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (liczby[j] > liczby[j + 1])
                    {
                        // Zamiana elementów, jeśli są w złej kolejności
                        int temp = liczby[j];
                        liczby[j] = liczby[j + 1];
                        liczby[j + 1] = temp;
                    }
                }
            }
        }


        private static int[] WczytajTablice()
        {
            Console.WriteLine("Podaj dowolną ilość liczb oddzielonych spacją: ");
            string[] sLiczby = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int[] liczby = new int[sLiczby.Length];
            for (int i = 0; i < sLiczby.Length; i++)
            {
                liczby[i] = int.Parse(sLiczby[i]);
            }

            return liczby;
        }

        private static int CalculateDividy(int x, int y)
        {
            if (y == 0)
                throw new ArgumentException("Pamiętaj cholero! Nie dziel przez 0!");

            return x / y;
        }

        public static int CalculateAdd(int x, int y)
        {
            return x + y;
        }

        private static void PokazBlad(string wiadomosc)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(wiadomosc);
            Console.ResetColor();
        }

        private static void PobierzXY(out int x, out int y)
        {
            Console.Clear();
            Console.Write("Podaj X: ");
            x = int.Parse(Console.ReadLine());

            Console.Write("Podaj Y: ");
            y = int.Parse(Console.ReadLine());
        }

        private static void PokazMenu()
        {
            Console.Clear();
            Console.WriteLine("KALKULATOR 1.0");
            Console.WriteLine("  1. Dodawanie");
            Console.WriteLine("  2. Odejmowanie");
            Console.WriteLine("  3. Mnożenie");
            Console.WriteLine("  4. Dzielenie");
            Console.WriteLine("  5. Sortowanie");
        }
    }
}
