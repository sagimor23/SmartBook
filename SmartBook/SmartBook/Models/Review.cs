﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SmartBook.Models
{
    public class Review
    {
        [Display(Name = "Review ID")]
        public int ReviewId { get; set; }

        [Required]
        [Display(Name = "Book ID")]
        public int BookId { get; set; }

        [Required]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "Comment")]
        [StringLength(400, ErrorMessage = "Comment cannot be more than 400 characters.")]
        public string ReviewText { get; set; }

        [Required]
        [Display(Name = "Rating")]
        [Range(1, 5, ErrorMessage = "Rating must be between 1-5.")]
        public int ReviewRating { get; set; }

        [Required]
        [Display(Name = "Review Date")]
        [DataType(DataType.DateTime, ErrorMessage = "This field must be a valid DateTime")]
        public DateTime ReviewDate { get; set; }

        public virtual Book Book { get; set; }

    }
}
