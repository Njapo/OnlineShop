﻿using System.ComponentModel.DataAnnotations;

namespace OnlineShop_Web.Models
{
    public class ItemCreateDTO
    {
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string? PhotoUrl { get; set; }

    }
}
