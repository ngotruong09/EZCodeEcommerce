using System;
using Volo.Abp.Application.Dtos;

namespace EZCode.ProductService.Products
{
    public class ProductDto: EntityDto<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
