using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.Viewmodels
{
    public class HomeViewModel
    {
        public IEnumerable<Book> BooksOfTheWeek { get; set; }
    }
}
