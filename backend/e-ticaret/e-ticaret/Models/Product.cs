using e_ticaret.Models;
using System.ComponentModel.DataAnnotations;

namespace e_ticaret.model
{
    public class Product 
    {
        public enum ProductType
        {
           Electronic,
           Outdoor,
           Toy,
           Dress
        }
        [Key]
        public int Id { get; set; }
        public string TradeMark { get; set; }   
        public string Category { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }

        public ProductType Product_Type { get; set; }
        
    }
}
