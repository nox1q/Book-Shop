using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class IsCategoryName: ValidationAttribute
    {
        private readonly CategoryRepository _categoryRepository;

        public string getErrorMessage() => "This category is exists";

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (_categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == (string)value) != null)
            {
                return ValidationResult.Success;
            }
            return new ValidationResult(getErrorMessage());

        }
    }
}
