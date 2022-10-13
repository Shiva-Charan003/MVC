using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Models;

namespace Web.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSoruce();
        }
        public BookModel GetBookById(int id)
        {
            return DataSoruce().Where(x => x.Id == id).FirstOrDefault();
        }
        public List<BookModel> SearchBook(string title,string authorName)
        {
            return DataSoruce().Where(x => x.Title.Contains(title) && x.Author.Contains(authorName)).ToList();
        }
        private List<BookModel> DataSoruce()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id=1,Title="MVC",Author="Ram"},
                new BookModel(){Id=2,Title="MVC",Author="Ram"},
                new BookModel(){Id=3,Title="C#",Author="Kumar"},
                new BookModel(){Id=4,Title="JAVA",Author="Shiva"},
                new BookModel(){Id=5,Title="PYTHON",Author="Shiva"},
            };
        }
    }
}
