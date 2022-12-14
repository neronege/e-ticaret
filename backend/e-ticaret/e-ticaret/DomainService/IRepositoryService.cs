using e_ticaret.model;
using System.Collections.Generic;

namespace e_ticaret.DomainService
{
    public interface IRepositoryService<T>
        where T : Product
    {
        List<T> GetAll();
        T Add(T product);
        T GetByName(string name);
        void Delete(int id);

        T GetById(int id);

        T Update(T product);

        T GetByCost(int cost);

        List<T> toCostIncrease();

        List<T> toCostDecreasing();

        T GetCategory(string category);

        List<T> CostRange(int cost);
    }
}
