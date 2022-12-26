using e_ticaret.model;
using e_ticaret.Models;
using System.Collections.Generic;

namespace e_ticaret.DomainService
{
    public interface IProductService :  IRepository<Product>
    {
        List<Product> GetElectronics();
        List<Product> GetOutdoors();
        List<Product> GetDresses();
        List<Product> GetToys();
        List<Product> GetProductsBySubCategory(ProductType productType, int subCategory);
        List<Product> GetSubCategory(int subCategory);
        List<(int, string)> GetSubCategoriesByProductType(ProductType productType);
        List<Product> GetProductsByProductType(ProductType productType);
        List<Product> toCostIncrease(int subCategory);
        List<Product> toCostDecreasing(int subCategory);
    }
}
