using e_ticaret.model;
using e_ticaret.Models;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;

namespace e_ticaret.DomainService
{
    public class ProductCRUD : IProductCRUD
    {
        private readonly ApplicationDbContext context;

        public ProductCRUD(ApplicationDbContext context)
        {
            this.context = context;
        }

        public Product Add(ProductModel model)
        {
            var product = new Product
            { 
                 
                Name = model.Name,
                Description = model.Description,
                Category = model.Category,
                Cost = model.Price,
                CreatedOn = DateTime.Now,
                UpdatedOn = DateTime.Now

            };
            context.Products.Add(product);
            context.SaveChanges();
            return product;
        }

        public void Delete(int id)
        {
            var model = GetById(id);
            context.Remove(model);
            context.SaveChanges();
        }

        public List<Product> GetAll()
        {
            return context.Products.ToList();
        }

        public Product GetById(int id)
        {
            return context.Products.Find(id);
        }

        public Product GetByName(string name)
        {
          return context.Products.Where(x =>x.Name == name).FirstOrDefault();
        }

        public Product Update(ProductModel model)
        {
            var get = GetById(model.Id);
            if(get != null)
            {
                get.Name = model.Name;
                get.Description = model.Description;
                get.Category = model.Category;
                get.Cost = model.Price;
                get.CreatedOn = DateTime.Now;
            }
            context.Products.Update(get);
            context.SaveChanges();
            return get;
        }

    }
}
