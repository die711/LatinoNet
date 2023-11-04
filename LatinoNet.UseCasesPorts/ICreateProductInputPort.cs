using System.Threading.Tasks;
using LatinoNet.DTOs;

namespace LatinoNet.UseCasesPorts
{
    public interface ICreateProductInputPort
    {
        Task Handle(CreateProductDto productDto);
    }
}