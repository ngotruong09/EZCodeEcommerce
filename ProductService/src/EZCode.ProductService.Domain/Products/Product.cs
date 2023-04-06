using System;
using Volo.Abp.Domain.Entities;

namespace EZCode.ProductService.Products
{
    public class Product: Entity<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
