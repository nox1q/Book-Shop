using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class MockBookRepository: IBookRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Book> AllBooks =>
            new List<Book>
            {
                new Book {BookId=1, Name = "Savaging The Dark", Price = 15.95M, ShortDescription="Lorem", LongDescription="Lorem",Category = _categoryRepository.AllCategories.ToList()[0]},
                new Book {BookId=2, Name = "World War Z",       Price = 17.25M, ShortDescription="Lorem", LongDescription="Lorem",Category = _categoryRepository.AllCategories.ToList()[1]},
                new Book {BookId=3, Name = "Little Star",       Price = 15.95M, ShortDescription="Lorem", LongDescription="Lorem",Category = _categoryRepository.AllCategories.ToList()[0]},
                new Book {BookId=4, Name = "The Other",         Price = 15.95M, ShortDescription="Lorem", LongDescription="Lorem",Category = _categoryRepository.AllCategories.ToList()[2]}
            };
        public IEnumerable<Book> BooksOfTheWeek { get; }
        public Book GetBookById(int bookId)
        {
            return AllBooks.FirstOrDefault(p => p.BookId == bookId);
        }
        public void Update(Book book)
        {
            
        }
        public void Add(Book book)
        {

        }
        public void Delete(Book book)
        {

        }
    }
}
