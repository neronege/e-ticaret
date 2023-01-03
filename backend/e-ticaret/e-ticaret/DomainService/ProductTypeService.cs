using e_ticaret.Models;
using System.Collections.Generic;
using System.Linq;

namespace e_ticaret.DomainService
{
    public class ProductTypeService : Repository<ApplicationDbContext,ProductType>, IProductTypeService
    {
        public ProductTypeService(ApplicationDbContext context) : base(context)
        {
        }

        public List<ProductTypeDTO> GetCategories()
        {
           var list = _context.ProductTypes
                    .Select(x => new ProductTypeDTO
                    {
                        Id = x.Id,
                        Name = x.Name
                    }).ToList();
            return list;    
        }

        public List<ProductTypeDTO> GetSubCategories(int id)
        {
            var cat = _context.ProductTypes.FirstOrDefault(x => x.Id == id);
            if (cat != null)
            {
                var list = cat.SubTypes
                    .Select(x => new ProductTypeDTO
                    {
                        Id = x.Id,
                        Name = x.Name
                    }).ToList();
                return list;
            }
            return null;
        }
    }
}
