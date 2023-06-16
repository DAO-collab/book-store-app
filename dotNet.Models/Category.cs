﻿using System.ComponentModel.DataAnnotations;

namespace dotNet.Models
{
    public class Category
    {
        [Key]
        public int category_id { get; set; }
        [Required]
        [MaxLength(30)]
        public string name { get; set; } = null!; 
        [Range(1,50)]
        public int DisplayOrder { get; set; }


    }
}
