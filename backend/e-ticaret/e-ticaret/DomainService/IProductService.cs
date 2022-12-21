using e_ticaret.model;
using e_ticaret.Models;
using System.Collections.Generic;

namespace e_ticaret.DomainService
{
    public interface IProductService :  IRepository<Product>
    {
        List<Product> GetElectronics();
        List<Product> GetOutdors();
        List<Product> GetDresses();
        List<Product> GetToys();
        List<Product> GetProductsBySubCategory(ProductType productType, int subCategory);
        List<int> GetSubCategoriesByProductType(ProductType productType);
    }
}
