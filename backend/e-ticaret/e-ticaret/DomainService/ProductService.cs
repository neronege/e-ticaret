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
            return _context.Products.Where(x => x.ProductType == ProductType.Dress).ToList();
        }

        public List<Product> GetElectronics()
        {
            return _context.Products.Where(x => x.ProductType == ProductType.Electronic).ToList();
        }

        public List<Product> GetOutdoors()
        {
            return _context.Products.Where(x => x.ProductType == ProductType.Outdoor).ToList();
        }

        public List<Product> GetToys()
        {
            return _context.Products.Where(x => x.ProductType == ProductType.Toy).ToList();
        }
        public List<Product> GetProductsBySubCategory(ProductType productType, int subCategory)
        {
            return _context.Products.Where(x => x.ProductType == productType
                && x.SubType == subCategory).ToList();
        }

        public List<(int, string)> GetSubCategoriesByProductType(ProductType productType)
        {
            List<(int, string)> list = new();
            if (productType == ProductType.Electronic)
            {
                list.Add(((int)ElectronicType.Phone, ElectronicType.Phone.ToString()));
                list.Add(((int)ElectronicType.Computer, ElectronicType.Computer.ToString()));
                list.Add(((int)ElectronicType.Fridge, ElectronicType.Fridge.ToString()));
                list.Add(((int)ElectronicType.Tv, ElectronicType.Tv.ToString()));

            }
            if (productType == ProductType.Dress)
            {
                list.Add(((int)DressType.Dress, DressType.Dress.ToString()));
                list.Add(((int)DressType.Pant, DressType.Pant.ToString()));
                list.Add(((int)DressType.Suit, DressType.Suit.ToString()));
                list.Add(((int)DressType.Shirt, DressType.Shirt.ToString()));
            }
            if (productType == ProductType.Outdoor)
            {
                list.Add(((int)OutdoorType.Rollerblade, OutdoorType.Rollerblade.ToString()));
                list.Add(((int)OutdoorType.Skateboard, OutdoorType.Skateboard.ToString()));
                list.Add(((int)OutdoorType.Bicycle, OutdoorType.Bicycle.ToString()));
                list.Add(((int)OutdoorType.Scooter, OutdoorType.Scooter.ToString()));
            }
            if (productType == ProductType.Toy)
            {
                list.Add(((int)ToyType.Game, ToyType.Game.ToString()));
                list.Add(((int)ToyType.Puzzle, ToyType.Puzzle.ToString()));
                list.Add(((int)ToyType.Doll, ToyType.Doll.ToString()));
                list.Add(((int)ToyType.Car, ToyType.Car.ToString()));
            }
            return list;
        }



        public List<Product> GetProductsByProductType(ProductType productType)
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
