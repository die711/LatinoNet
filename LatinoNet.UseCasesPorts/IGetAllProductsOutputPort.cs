using System.Collections.Generic;
using System.Threading.Tasks;
using LatinoNet.DTOs;

namespace LatinoNet.UseCasesPorts
{
    public interface IGetAllProductsOutputPort
    {
        Task Handle(IEnumerable<ProductDto> products);
    }
}