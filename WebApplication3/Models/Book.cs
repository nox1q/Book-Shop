using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string AllergyInformation { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public bool isBookOfTheWeek { get; internal set; }
        public bool inStock { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (ShortDescription.Length > 100)
            {
                yield return new ValidationResult("Short description cannot exceed length 100", new[] { nameof(ShortDescription) });
            }
        }
    }
}
