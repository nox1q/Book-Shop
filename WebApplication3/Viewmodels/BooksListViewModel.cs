using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.Viewmodels
{
    public class BooksListViewModel
    {
        public IEnumerable<Book> Books { get; set;}
        public string CurrentCategory { get; set; }
    }
}
