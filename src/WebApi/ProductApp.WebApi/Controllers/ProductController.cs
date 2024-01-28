using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductApp.Application.DTO;
using ProductApp.Application.Features.Commands.CreateProduct;
using ProductApp.Application.Features.Queries.GetAllProducts;
using ProductApp.Application.Features.Queries.GetProductById;
using ProductApp.Application.Interfaces.Repository;

namespace ProductApp.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator mediator;

        public ProductController(IMediator mediator)
        {
            this.mediator = mediator;
        }



        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var query = new GetAllProductsQuery();

            return Ok( await mediator.Send(query));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var query = new GetProductByIdQuery() { Id = id};

            return Ok(await mediator.Send(query));
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateProductCommand command)
        {
            return Ok(await mediator.Send(command));
        }


    }
}
