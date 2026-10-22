using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBookManagement_Kristiqn_11g
{
    internal class Book
    {
        private string title;
        private string author;
        private int year;
        private string genre;
        private double price;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public Book(string title, string author, int year, string genre, double price)
        {
            Title = title;
            Author = author;
            Year = year;
            Genre = genre;
            Price = price;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Заглавие: " +
                $"{Title} | Автор: " +
                $"{Author} | Година: " +
                $"{Year} | Жанр: " +
                $"{Genre} | Цена: " +
                $"{Price:F2} лв.");
        }
    }
}
