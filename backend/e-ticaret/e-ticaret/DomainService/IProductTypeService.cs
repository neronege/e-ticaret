using e_ticaret.Models;
using System.Collections.Generic;

namespace e_ticaret.DomainService
{
    public interface IProductTypeService : IRepository<ProductType>
    {
        List<ProductTypeDTO> GetCategories();
        List<ProductTypeDTO> GetSubCategories(int id);
        
        
    }
}
