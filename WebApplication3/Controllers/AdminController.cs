using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;
using WebApplication3.Viewmodels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace WebApplication3.Controllers
{
    public class AdminController : Controller
    {
        private readonly IBookRepository _bookRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;

        public AdminController(IBookRepository bookRepository, ICategoryRepository categoryRepository, SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager)
        {
            _bookRepository = bookRepository;
            _categoryRepository = categoryRepository;
            _signInManager = signInManager;
            _userManager = userManager;
        }
        // Admin: kek@mail.ru Password: Asdf!123
        [Authorize(Roles ="ROLE_ADMIN")]
        public ViewResult Index()
        {
            //if (_signInManager.IsSignedIn(User) && User.Identity.Name.Equals("admin@gmail.com")) {
                var books = _bookRepository.AllBooks;
                return View(books);
            //} else
             //   return View("Denied");
        }
        public ViewResult Denied()
        {
            return View("Denied");
        }

        [HttpGet]
        public IActionResult Create()
        {
            //if (_signInManager.IsSignedIn(User) && User.Identity.Name.Equals("admin@gmail.com")){
                var book = new Book();
                var categories = _categoryRepository.AllCategories;
                if (book == null)
                    return NotFound();
                return View(new BookViewModel
                {
                    Book = book,
                    Categories = categories
                });
            //}
            //else
             //   return View("Denied");
            
        }
        [HttpPost]
        public async Task<IActionResult> Create(BookViewModel model)
        {
            var book = new Book();
            book.Name = model.Book.Name;
            book.ImageUrl = model.Book.ImageUrl;
            book.ImageThumbnailUrl = model.Book.ImageUrl;
            book.ShortDescription = model.Book.ShortDescription;
            book.LongDescription = model.Book.LongDescription;
            book.Price = model.Book.Price;
            book.Category = _categoryRepository.GetCategoryById(model.Book.CategoryId);
            Console.WriteLine(book.Name);
            _bookRepository.Add(book);

            var books = _bookRepository.AllBooks;
            //return RedirectToAction("Index");
            return View("Index", books);

        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            //if (_signInManager.IsSignedIn(User) && User.Identity.Name.Equals("admin@gmail.com")) { 

                var book = _bookRepository.GetBookById(id);
                var categories = _categoryRepository.AllCategories;
                if (book == null)
                    return NotFound();
                return View(new BookViewModel
                {
                    Book = book,
                    Categories = categories
                });

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
           // }
            //else
             //   return View("Denied");
           
        }
        [HttpPost]
        public async Task<IActionResult> Edit(BookViewModel model)
        {
            var book = _bookRepository.GetBookById(model.Book.BookId);
            
            book.Name = model.Book.Name;
            book.ImageUrl = model.Book.ImageUrl;
            book.ImageThumbnailUrl = model.Book.ImageUrl;
            book.ShortDescription = model.Book.ShortDescription;
            book.LongDescription = model.Book.LongDescription;
            book.Price = model.Book.Price;
            book.Category = _categoryRepository.GetCategoryById(model.Book.CategoryId);
            Console.WriteLine(book.Name);
            _bookRepository.Update(book);

            var books = _bookRepository.AllBooks;
            //return RedirectToAction("Index");
            return View("Index", books);

        }
        [HttpPost]
        public async Task<IActionResult> Delete(int id )
        {
            var book = _bookRepository.GetBookById(id);

           
            _bookRepository.Delete(book);

            IEnumerable<Book> books = _bookRepository.AllBooks;

            //return RedirectToAction("Index");
            return View("Index", books);

        }

    }
}