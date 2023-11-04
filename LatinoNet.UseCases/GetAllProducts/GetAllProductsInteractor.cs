using System.Linq;
using System.Threading.Tasks;
using LatinoNet.DTOs;
using LatinoNet.Entities.Interfaces;
using LatinoNet.UseCasesPorts;

namespace LatinoNet.UseCases.GetAllProducts
{
    public class GetAllProductsInteractor : IGetAllProductsInputPort
    {
        private readonly IProductRepository _repository;
        private readonly IGetAllProductsOutputPort _outputPort;

        public GetAllProductsInteractor(IProductRepository repository, IGetAllProductsOutputPort outputPort)
        {
            _repository = repository;
            _outputPort = outputPort;
        }
        
        public Task Handle()
        {
            var products = _repository.GetAll().Select(p =>
                new ProductDto
                {
                    Id = p.Id,
                    Name = p.Name
                });

            _outputPort.Handle(products);
            return Task.CompletedTask;

        }
    }
}