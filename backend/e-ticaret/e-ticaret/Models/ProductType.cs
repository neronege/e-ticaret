using System.Collections.Generic;

namespace e_ticaret.Models
{
    public class ProductType: EntityBase, IEntity
    {
        virtual public List<ProductType> SubTypes { get; set; }
        public int? ParentId { get; set; }
        public ProductType(int id, string name)
        {
            Id = id;
            Name = name;
            SubTypes = new();
        }
        public ProductType()
        {
                
        }
    }
}
