using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.Viewmodels
{
    public class BookViewModel
    {
        public Book Book { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}
