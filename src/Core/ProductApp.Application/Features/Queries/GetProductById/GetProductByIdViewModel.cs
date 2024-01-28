using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Application.Features.Queries.GetProductById
{
    public class GetProductByIdViewModel
    {
        public Guid Id { get; set; }
        public DateTime CreateDate { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }

        public int Quantity { get; set; }
    }
}
