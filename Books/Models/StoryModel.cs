using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Books.Models
{
    public class StoryModel
    {
        [Key]
        public int StoryId { get; set; }
        [Required]
        public string StoryTitle { get; set; }
        public string GenreId { get; set; }

        [ValidateNever]
        public GenreModel Genre { get; set; }
        public AppUserModel User { get; set; }

        [StringLength(500, MinimumLength = 10)]
        [Required]
        public string StoryPlace { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime StoryDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime Date { get; set; }

        [StringLength(500, MinimumLength = 10)]
        [Required]
        public string Story { get; set; }
        public ICollection<CommentsModel> Comments { get; set; }
    }
}
