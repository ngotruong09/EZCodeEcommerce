using EZCode.ProductService.EntityFrameworkCore;
using System;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace EZCode.ProductService.Products
{
    public class EfCoreProductRepository : EfCoreRepository<ProductServiceDbContext, Product, Guid>, IProductRepository
    {
        public EfCoreProductRepository(IDbContextProvider<ProductServiceDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
