using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Books.Models
{
    public class BookModel
    {
        [Key]
        public int BookId { get; set; }

        [Required]
        public string Title { get; set; }
        public string Author { get; set; }

        [StringLength(500, MinimumLength = 10)]
        [Required]
        public string Description { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime Date { get; set; }

        [Range(1, 5)]
        public int? Rating { get; set; }
        public string GenreId { get; set; }

        [ValidateNever]
        public GenreModel Genre { get; set; } = null!;
    }
}
