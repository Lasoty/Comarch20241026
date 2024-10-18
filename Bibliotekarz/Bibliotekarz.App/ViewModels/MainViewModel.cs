using Bibliotekarz.Data.Context;
using Bibliotekarz.Data.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace Bibliotekarz.App.ViewModels
{
    public class MainViewModel
    {
        public MainViewModel()
        {
            FilterText = "Leszek";
            //GenerateFakeData();
            GetData();
            //AddBook();
            //EditBook();
        }

        private void EditBook()
        {
            using AppDbContext dbContext = new AppDbContext();

            Book book = dbContext.Books.First(b => b.Id == 1);
            book.Title = "Adam Nowak";

            dbContext.Books.Update(book);
            dbContext.SaveChanges();
        }

        private void AddBook()
        {
            using AppDbContext dbContext = new AppDbContext();

            dbContext.Books.Add(new Book { Author = "Leszek Lewandowski", Title = "Programowanie w C#", PageCount = 234, IsBorrowed = false });
            dbContext.SaveChanges();
        }

        private void GetData()
        {
            using AppDbContext dbContext = new AppDbContext();
            var books = dbContext.Books
                .Where(book => book.IsBorrowed == false)
                .OrderByDescending(book => book.Author)
                .ThenBy(book => book.Title)
                .ToList();

            foreach (var book in books)
            {
                Books.Add(book);
            }
        }

        public string FilterText { get; set; }

        public ObservableCollection<Book> Books { get; set; } = [];

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
