using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Comarch20241016.App.CarManager
{
    internal class CarApp
    {
        public void RunCarManager()
        {
            int wybor; 
            do
            {
                PokazMenu();
                if (int.TryParse(Console.ReadLine(), out wybor))
                {
                    UruchomAkcje(wybor);
                }
                else
                {
                    PokazError("Nieprawidłowa pozycja menu!");
                }

            } while (wybor != 0);
        }

        private void UruchomAkcje(int wybor)
        {
            switch (wybor)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                default:
                    break;
            }
        }

        private void PokazError(string msg)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(msg);
            Console.ResetColor();
        }

        private void PokazMenu()
        {
            Console.WriteLine("CAR MANAGER 1.0");
            Console.WriteLine("  1. Lista pojazdów");
            Console.WriteLine("  2. Dodaj auto");
            Console.WriteLine("  3. Wypożycz auto");
            Console.WriteLine("  0. Zakończ");
        }
    }
}
