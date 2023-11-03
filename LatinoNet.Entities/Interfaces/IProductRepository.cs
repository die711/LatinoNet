using System.Collections.Generic;
using LatinoNet.Entities.POCOs;

namespace LatinoNet.Entities.Interfaces
{
    public interface IProductRepository
    {
        void CreateProduct(Product product);
        IEnumerable<Product> GetAll();
    }
}