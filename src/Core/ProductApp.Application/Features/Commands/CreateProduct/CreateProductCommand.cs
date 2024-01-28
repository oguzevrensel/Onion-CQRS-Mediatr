using AutoMapper;
using MediatR;
using ProductApp.Application.Interfaces.Repository;
using ProductApp.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Application.Features.Commands.CreateProduct
{
    public class CreateProductCommand : IRequest<ServiceResponse<Guid>>
    {
        public string Name { get; set; }
        public int Value { get; set; }

        public int Quantity { get; set; }

        public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand,ServiceResponse<Guid>>
        {
            IProductRepository productRepository;
            private readonly IMapper mapper;

            public CreateProductCommandHandler(IProductRepository repository, IMapper mapper)
            {
                productRepository = repository;
                this.mapper = mapper;
            }

            public async Task<ServiceResponse<Guid>> Handle(CreateProductCommand request, CancellationToken cancellationToken)
            {
                var product = mapper.Map<Domain.Entities.Product>(request);
                await productRepository.AddAsynch(product);

                return new ServiceResponse<Guid>(product.Id);
            }
        }
    }
}
