using e_ticaret.model;
using e_ticaret.Models;
using Microsoft.AspNetCore.Mvc;
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
            return null;
        }

        public List<Product> GetElectronics()
        {
            return null;
        }

        public List<Product> GetOutdoors()
        {
            return null;
        }

        public List<Product> GetToys()
        {
            return null;
        }
        public List<Product> GetProductsBySubCategory(int productType, int subCategory)
        {
            return _context.Products.Where(x => x.ProductType == productType
                && x.SubType == subCategory).ToList();
        }

        public List<(int, string)> GetSubCategoriesByProductType(ProductType productType)
        {
            List<(int, string)> list = new();
       
            return list;
        }



        public List<Product> GetProductsByProductType(int productType)
        {
            return _context.Products.Where(x => x.ProductType == productType).ToList();
        }

        public List<Product> GetSubCategory(int subCategory)
        {
            return _context.Products.Where(x => x.SubType == subCategory).ToList();
        }

        public List<Product> toCostDecreasing(int subCategory)
            
        {
            var products = GetSubCategory(subCategory);
            foreach (object x in products) {

                IEnumerable<Product> query = _context.Set<Product>().OrderByDescending(x => x.Cost);

                return query.ToList();
            }
            return products;
        }

        public List<Product> toCostIncrease(int subCategory)
        {
             var products = GetSubCategory(subCategory);
            foreach (object x in products)
            {

                IEnumerable<Product> query = _context.Set<Product>().OrderByDescending(x => x.Cost);

                return query.ToList();
            }
            return products;
        }

     
    }
}
