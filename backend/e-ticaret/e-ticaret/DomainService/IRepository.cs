using e_ticaret.model;
using e_ticaret.Models;
using System.Collections.Generic;

namespace e_ticaret.DomainService
{
    public interface IRepository<T>
        where T : IEntity
    {
        List<T> GetAll();
        T Add(T product);
        T GetByName(string name);
        void Delete(int id);
        T GetById(int id);
        T Update(T entity);
        T InsertOrUpdate(T entity);
      
    }
}
