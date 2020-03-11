using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLib
{
    interface IBookCollection
    {
        List<Book> GetAll();
        Book GetByPosition(int position);
        List<Book> GetByAuthor(string author);
        List<Book> GetByName(string name);
        List<Book> GetByAuthors(List<string> authors);
        List<Book> GetByWord(string word);

    }
    public class BookCollection : IBookCollection
    {
        public List<Book> books = new List<Book>();
        public BookCollection()
        {
            books.Add(new Book("Достоевский", "Преступление и наказание", "Убил старушку, горемыка"));
            books.Add(new Book("Гоголь", "Мертвые души", "Мертвецы восстали"));
            books.Add(new Book("Толстой", "Война и мир", "Была война, теперь мир"));
            books.Add(new Book("Иванов", "Тополя", "Тополиный пух, жара, июль"));
        }

        public List<Book> GetAll()
        {
            return books;
        }
        public Book GetByPosition(int position)
        {
            var GetByPosition = books[position];
            return GetByPosition;
        }
        public List<Book> GetByAuthor(string author)
        {
            var selectAuthor = books.Where(u => u.Author.Contains(author)).ToList();
            return selectAuthor;
        }

        public List<Book> GetByName(string name)
        {
            var md = books.Exists(u => u.Name == name);
            var selectName = books.Where(u => u.Name.Contains(name)).ToList();
            return selectName; 
        }

        public List<Book> GetByAuthors(List<string> authors)
        {
            var selectManyAuthors = books.Where(u => authors.Contains(u.Author)).ToList();
            return selectManyAuthors;
        }

        public List<Book> GetByWord(string word)
        {
            var selectByWord = books.Where(u => u.Text.Contains(word)).ToList();
            return selectByWord;
        }

    }

}
