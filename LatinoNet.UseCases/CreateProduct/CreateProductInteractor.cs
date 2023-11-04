using System.Threading.Tasks;
using LatinoNet.DTOs;
using LatinoNet.Entities.Interfaces;
using LatinoNet.Entities.POCOs;
using LatinoNet.UseCasesPorts;

namespace LatinoNet.UseCases.CreateProduct
{
    public class CreateProductInteractor : ICreateProductInputPort
    {
        private readonly IProductRepository _productRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICreateProductOutputPort _outputPort;

        public CreateProductInteractor(IProductRepository productRepository, IUnitOfWork unitOfWork, ICreateProductOutputPort outputPort)
        {
            _productRepository = productRepository;
            _unitOfWork = unitOfWork;
            _outputPort = outputPort;
        }
        
        public async Task Handle(CreateProductDto productDto)
        {
            var newProduct = new Product()
            {
                Name = productDto.ProductName
            };
            
            _productRepository.CreateProduct(newProduct);
            await _unitOfWork.SaveChanges();
            await _outputPort.Handle(new ProductDto
            {
                Id = newProduct.Id,
                Name = newProduct.Name
            });
        }
    }
}