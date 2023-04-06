using System;
using System.Collections.Generic;
using System.Text;

namespace EZCode.ProductService.Products
{
    public class GetProductsInput
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal? PriceMin { get; set; }
        public decimal? PriceMax { get; set; }
    }
}
