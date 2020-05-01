using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;
using WebApplication3.Viewmodels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication3.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository _bookRepository;
        private readonly ICategoryRepository _categoryRepository;

        public BookController(IBookRepository bookRepository, ICategoryRepository categoryRepository)
        {
            _bookRepository = bookRepository;
            _categoryRepository = categoryRepository;
        }

        /*
        public IActionResult List()
        {

            BooksListViewModel booksListViewModel = new BooksListViewModel();
            booksListViewModel.Books = _bookRepository.AllBooks;
            booksListViewModel.CurrentCategory = "Horror Books";
            return View(booksListViewModel);
        }
        */
        public ViewResult List(string category)
        {
            IEnumerable<Book> books;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                books = _bookRepository.AllBooks.OrderBy(p => p.BookId);
                currentCategory = "All books";
            }
            else
            {
                books = _bookRepository.AllBooks.Where(p => p.Category.CategoryName == category)
                    .OrderBy(p => p.BookId);
                currentCategory = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }

            return View(new BooksListViewModel
            {
                Books = books,
                CurrentCategory = currentCategory
            });
        }
        public IActionResult Details(int id)
        {
            var book = _bookRepository.GetBookById(id);
            if (book == null)
                return NotFound();
            return View(book);

        }
    }
}
