using System;
using System.Collections.Generic;

namespace BookLib
{
    class Program
    {

        static void Main(string[] args)
        {
            BookCollection bookCollection = new BookCollection();
            var c = bookCollection.GetByAuthors(new List<string> { "Толстой", "Достоевский"});
            ShowList(c);
            Console.ReadLine();
        }
        static void ShowList(List<Book> books)
        {
            foreach (Book book in books)
            {
                Console.WriteLine(book);
            }
        }
    }

    public class Book
    {
        public string Author;
        public string Name;
        public string Text;
        public Book(string Author, string Name, string Text)
        {
            this.Author = Author;
            this.Name = Name;
            this.Text = Text;
        }
        public override string ToString()
        {
            return $"Имя: {Name}, Автор: {Author}, Текст: {Text}";
        }

    }

}
