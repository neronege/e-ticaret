using e_ticaret.Models;
using System.ComponentModel.DataAnnotations;

namespace e_ticaret.model
{
    public class Product :BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public string Category { get; set; }
        
        public decimal Cost { get; set; }
        
    }
}
