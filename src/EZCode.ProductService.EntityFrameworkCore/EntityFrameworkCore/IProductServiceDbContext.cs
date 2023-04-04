using EZCode.ProductService.Products;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace EZCode.ProductService.EntityFrameworkCore;

[ConnectionStringName(ProductServiceDbProperties.ConnectionStringName)]
public interface IProductServiceDbContext : IEfCoreDbContext
{
   DbSet<Product> Products { get; set; }
}
