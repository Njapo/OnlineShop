using System.ComponentModel.DataAnnotations;

namespace OnlineShop_api.Models
{
    public class ItemUpdateDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }              
        public string Description { get; set; }       
        public decimal? Price { get; set; }           
        public int? Quantity { get; set; }            
        public string PhotoUrl { get; set; }

    }
}
