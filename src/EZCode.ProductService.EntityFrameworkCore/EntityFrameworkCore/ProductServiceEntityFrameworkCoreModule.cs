using EZCode.ProductService.Products;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace EZCode.ProductService.EntityFrameworkCore;

[DependsOn(
    typeof(ProductServiceDomainModule),
    typeof(AbpEntityFrameworkCoreModule)
)]
public class ProductServiceEntityFrameworkCoreModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<ProductServiceDbContext>(options =>
        {
            options.AddRepository<Product, EfCoreProductRepository>();
        });
    }
}
