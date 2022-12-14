using e_ticaret.Migrations;
using e_ticaret.model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Update;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace e_ticaret.DomainService
{
    public class RepositoryBase<T, TContext> : IRepositoryService<T>
        where T : Product
        where TContext :DbContext
       
    {
        private readonly TContext _context;
        private List<T> products;

        public RepositoryBase(TContext context)
        {
            _context = context;
        }

        public T Add(T product)
        {
            _context.Set<T>().Add(product);
            _context.SaveChanges();
            return product;
        }

        public List<T> CostRange(int cost)
        {
            object products = new  { };
            var price = GetByCost(cost);

            if (price != null)
            {
                if (cost <= 500)
                {
                    this.products =  _context.Set<T>().AsNoTracking().Where(x => x.Cost <= 500).ToList();
                 
                }

                if (cost > 500 && cost <= 2000)
                {
                    this.products = _context.Set<T>().AsNoTracking().Where(x => x.Cost > 500 && x.Cost <= 2000).ToList();

                }
                if (cost > 2000 && cost <= 5000)
                {
                    this.products = _context.Set<T>().AsNoTracking().Where(x => x.Cost > 2000 && x.Cost <= 5000).ToList();

                }
                if (cost > 5000 && cost <= 10000)
                {
                    this.products = _context.Set<T>().AsNoTracking().Where(x => x.Cost > 5000 && x.Cost <= 10000).ToList();

                }
                if (cost > 10000)
                {
                    this.products = _context.Set<T>().AsNoTracking().Where(x => x.Cost > 10000).ToList();
                }
            }
            return this.products;
           
        }
        public void Delete(int id)
        {
            var model = _context.Set<T>().Find(id);
            _context.Set<T>().Remove(model);
            _context.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetByCost(int cost)
        {
            return _context.Set<T>().Find(cost);
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public T GetByName(string name)
        {
            return _context.Set<T>().Where(x => x.Name == name).FirstOrDefault();
        }

        public T GetCategory(string category)
        {
            return _context.Set<T>().Where(x => x.Category == category).FirstOrDefault();
        }

        public List<T> toCostDecreasing()
        {
            IEnumerable<T> query = _context.Set<T>().OrderByDescending(x => x.Cost);

            return query.ToList();
        }

        public List<T>toCostIncrease()
        {
            IEnumerable<T>  query = _context.Set<T>().OrderBy(x => x.Cost);
            
            return query.ToList();
        }

        public T Update(T model)
        {
            _context.Set<T>().Update(model);
            _context.SaveChanges();
            return model;
        }
    }
}
