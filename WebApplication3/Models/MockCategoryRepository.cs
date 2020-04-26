using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class MockCategoryRepository: ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Horror books",Description="All-horror books"},
                new Category{CategoryId=2, CategoryName="Humor books",Description="All-humor books"},
                new Category{CategoryId=3, CategoryName="Drama books",Description="All-drama books"}
            };
    }
}
