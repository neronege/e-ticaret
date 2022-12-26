using e_ticaret.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace e_ticaret.DomainService
{
    public class Repository<Tcontext, TEntity> : IRepository<TEntity>
        where Tcontext : ApplicationDbContext
        where TEntity : class, IEntity
    {
        protected readonly Tcontext _context;

        public Repository(Tcontext context)
        {
            _context = context;
        }

        public TEntity Add(TEntity entity)
        {
          
             _context.Set<TEntity>().Add(entity);
             _context.SaveChanges();
             return entity;
        }

        public void Delete(int id)
        {
            var model = _context.Set<TEntity>().Find(id);
            _context.Set<TEntity>().Remove(model);
            _context.SaveChanges();

        }

        public List<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public TEntity GetByName(string name)
        {
            return _context.Set<TEntity>().FirstOrDefault(x => x.Name.ToLower() == name.ToLower());
        }

        public TEntity InsertOrUpdate(TEntity entity)
        {
            if (entity.Id == 0)
            {
                Add(entity);
            }
            else
            {
                Update(entity);
            }
            return entity;
        }

        public TEntity Update(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
            _context.SaveChanges();
            return entity;
        }
    }
}
