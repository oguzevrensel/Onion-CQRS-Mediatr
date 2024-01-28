using MediatR;
using ProductApp.Application.DTO;
using ProductApp.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Application.Features.Queries.GetProductById
{
    public class GetProductByIdQuery :  IRequest<ServiceResponse<GetProductByIdViewModel>>
    {
        public Guid Id { get; set; }

    }
}
