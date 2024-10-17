using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comarch20241016.App.CarManager
{
    internal class CarRepository
    {
        private List<Car> dane = new List<Car>();

        public CarRepository()
        {
            GenerateFakeData();
        }

        public IEnumerable<Car> GetCars()
        {
            return dane;
        }

        public Car GetCar(int id)
        {
            return dane.FirstOrDefault(car => car.Id == id);
        }

        public void Add(Car car)
        {
            dane.Add(car);
        }

        private void GenerateFakeData()
        {
            int[] tab = { 1, 2, 3, 4, 5, 6 };

            dane = new List<Car>()
            {
                new Car()
                {
                    Id = 1,
                    Marka = "Audi",
                    Model = "A6",
                    RokProdukcji = 2008
                },

                new Car()
                {
                    Id = 2,
                    Marka = "BMW",
                    Model = "M5",
                    RokProdukcji = 2012
                },

                new Car()
                {
                    Id = 3,
                    Marka = "Mercedes",
                    Model = "GLS",
                    RokProdukcji = 2014
                }
            };
        }
    }
}
