namespace OnlineShop_api.Models
{
    public class ItemUpdateDTO
    {
        public int Id { get; set; }                  
        public string Name { get; set; }              
        public string Description { get; set; }       
        public decimal? Price { get; set; }           
        public int? Quantity { get; set; }            
        public string PhotoUrl { get; set; }

    }
}
