using System.Collections.Generic;
using LatinoNet.Entities.Interfaces;
using LatinoNet.Entities.POCOs;
using LatinoNet.RepositoryEFCore.DataContext;

namespace LatinoNet.RepositoryEFCore.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly LatinoNetContext _context;

        public ProductRepository(LatinoNetContext context)
        {
            _context = context;
        }
        
        public void CreateProduct(Product product)
        {
            _context.Add(product);
        }

        public IEnumerable<Product> GetAll()
        {
            return _context.Products;
        }
    }
}