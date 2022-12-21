using e_ticaret.model;
using e_ticaret.Models;
using System.Collections.Generic;
using System.Linq;

namespace e_ticaret.DomainService
{
    public class ProductService : Repository<ApplicationDbContext, Product>, IProductService
    {
        public ProductService(ApplicationDbContext context) : base(context)
        {
        }

        public List<Product> GetDresses()
        {
            return _context.Products.Where(x => x.ProductType == ProductType.Dress).ToList();
        }

        public List<Product> GetElectronics()
        {
            throw new System.NotImplementedException();
        }

        public List<Product> GetOutdors()
        {
            throw new System.NotImplementedException();
        }

        public List<Product> GetProductsBySubCategory(ProductType productType, int subCategory)
        {
            return _context.Products
                .Where(x => x.ProductType == productType
                && x.SubType == subCategory).ToList();
        }

        public List<(int,string)> GetSubCategoriesByProductType(ProductType productType)
        {
            List<(int,string)> list = new();
            if (productType == ProductType.Electronic)
            {
                list.Add(((int)ElectronicType.Phone,ElectronicType.Phone.ToString()));
                list.Add(((int)ElectronicType.Computer, ElectronicType.Computer.ToString()));

            }
            return list;
        }

        public List<Product> GetToys()
        {
            throw new System.NotImplementedException();
        }
    }
}
