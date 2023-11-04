using System.Collections.Generic;
using System.Threading.Tasks;
using LatinoNet.DTOs;
using LatinoNet.Presenters;
using LatinoNet.UseCasesPorts;
using Microsoft.AspNetCore.Mvc;

namespace LatinoNet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetAllProductsController
    {
        private readonly IGetAllProductsInputPort _inputPort;
        private readonly IGetAllProductsOutputPort _outputPort;

        public GetAllProductsController(IGetAllProductsInputPort inputPort, IGetAllProductsOutputPort outputPort)
        {
            _inputPort = inputPort;
            _outputPort = outputPort;
        }

        [HttpGet]
        public async Task<IEnumerable<ProductDto>> GetAllProducts()
        {
            await _inputPort.Handle();
            return ((IPresenter<IEnumerable<ProductDto>>)_outputPort).Content;
        }
    }
}