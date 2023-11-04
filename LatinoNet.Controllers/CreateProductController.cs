using System.Threading.Tasks;
using LatinoNet.DTOs;
using LatinoNet.Presenters;
using LatinoNet.UseCasesPorts;
using Microsoft.AspNetCore.Mvc;

namespace LatinoNet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreateProductController
    {
        private readonly ICreateProductInputPort _inputPort;
        private readonly ICreateProductOutputPort _outputPort;

        public CreateProductController(ICreateProductInputPort inputPort, ICreateProductOutputPort outputPort)
        {
            _inputPort = inputPort;
            _outputPort = outputPort;
        }
        
        [HttpPost]
        public async Task<ProductDto> CreateProduct(CreateProductDto product)
        {
            await _inputPort.Handle(product);
            return ((IPresenter<ProductDto>)_outputPort).Content;
        }
        
        
        
    }
}