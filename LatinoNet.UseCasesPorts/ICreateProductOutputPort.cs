using System.Threading.Tasks;
using LatinoNet.DTOs;

namespace LatinoNet.UseCasesPorts
{
    public interface ICreateProductOutputPort
    {
        Task Handle(ProductDto productDto);
    }
}