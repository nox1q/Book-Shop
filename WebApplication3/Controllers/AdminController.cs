using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;
using WebApplication3.Viewmodels;
namespace WebApplication3.Controllers
{
    public class AdminController : Controller
    {
        private readonly IBookRepository _bookRepository;
        private readonly ICategoryRepository _categoryRepository;

        public AdminController(IBookRepository bookRepository, ICategoryRepository categoryRepository)
        {
            _bookRepository = bookRepository;
            _categoryRepository = categoryRepository;
        }

        public async Task<IActionResult> Index()
        {
            var books = _bookRepository.AllBooks;
            return View(books);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var book = _bookRepository.GetBookById(id);
            var categories = _categoryRepository.AllCategories;
            if (book == null)
                return NotFound();
            return View(new BookViewModel
            {
                Book = book,
                Categories = categories
            }) ;

            /*  BookViewModel bookView = new BookViewModel { 
                   BookId = book.BookId,
                   Name = book.Name,
                   ShortDescription = book.ShortDescription,
                   LongDescription = book.LongDescription,
                   AllergyInformation = book.AllergyInformation,
                   Price = book.Price,
                   ImageUrl = book.ImageUrl,
                   ImageThumbnailUrl = book.ImageThumbnailUrl,
                   isBookOfTheWeek = book.isBookOfTheWeek,
                   inStock = book.inStock,
                   CategoryId = book.CategoryId,
                   Category = book.Category

               };
               */
        }

    }
}