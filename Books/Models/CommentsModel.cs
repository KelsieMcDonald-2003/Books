﻿using System.ComponentModel.DataAnnotations;

namespace Books.Models
{
    public class CommentsModel
    {
        [Key]
        public int CommentId { get; set; }
        public AppUserModel User { get; set; }

        [StringLength(500, MinimumLength = 10)]
        [Required]
        public string Comment { get; set; }
        public int StoryId { get; set; }
        public StoryModel Story { get; set; }
    }
}
