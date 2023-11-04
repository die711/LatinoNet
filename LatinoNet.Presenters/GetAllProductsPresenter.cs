using System.Collections.Generic;
using System.Threading.Tasks;
using LatinoNet.DTOs;
using LatinoNet.UseCasesPorts;

namespace LatinoNet.Presenters
{
    public class GetAllProductsPresenter : IGetAllProductsOutputPort, IPresenter<IEnumerable<ProductDto>>
    {
        public Task Handle(IEnumerable<ProductDto> products)
        {
            Content = products;
            return Task.CompletedTask;
        }

        public IEnumerable<ProductDto> Content { get; private set; }
    }
}