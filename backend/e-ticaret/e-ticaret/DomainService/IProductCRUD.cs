using e_ticaret.model;
using e_ticaret.Models;
using System.Collections.Generic;

namespace e_ticaret.DomainService
{
    public interface IProductCRUD
    {
        Product Add(ProductModel model);
        Product Update(ProductModel model);
        void Delete(int id);

        Product GetById(int id);

        List<Product> GetAll();

        Product GetByName(string Name);



    }
}