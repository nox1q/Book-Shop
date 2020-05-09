﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        [Required]
        [IsCategoryName]
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public List<Book> Books { get; set; }
        
    }
}
