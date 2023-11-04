using System.Threading.Tasks;
using LatinoNet.DTOs;
using LatinoNet.UseCasesPorts;

namespace LatinoNet.Presenters
{
    public class CreateProductPresenter : ICreateProductOutputPort, IPresenter<ProductDto>
    {
        public Task Handle(ProductDto productDto)
        {
            Content = productDto;
            return Task.CompletedTask;
        }

        public ProductDto Content { get; private set; }
    }
}