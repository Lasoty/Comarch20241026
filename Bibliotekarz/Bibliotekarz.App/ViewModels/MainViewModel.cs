using Bibliotekarz.App.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotekarz.App.ViewModels
{
    public class MainViewModel
    {
        public MainViewModel()
        {
            FilterText = "Leszek";
            GenerateFakeData();
        }

        public string FilterText { get; set; }

        public ObservableCollection<Book> Books { get; set; }

        private void GenerateFakeData()
        {
            Books = new ObservableCollection<Book>()
            {
                new Book { Id = 1, Author = "Leszek Lewandowski", Title = "Programowanie w C#", PageCount = 234, IsBorrowed = false },
                new Book { Id = 2, Author = "John Sharp", Title = "Visual C# Krok po kroku", PageCount = 345, IsBorrowed = true,
                    Borrower = new Customer { Id = 1, FirstName = "Adam", LastName = "Nowak" } }

            };
        }
    }
}
