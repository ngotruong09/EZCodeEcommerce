using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace EZCode.ProductService.EntityFrameworkCore;

public class ProductServiceHttpApiHostMigrationsDbContext : AbpDbContext<ProductServiceHttpApiHostMigrationsDbContext>
{
    public ProductServiceHttpApiHostMigrationsDbContext(DbContextOptions<ProductServiceHttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureProductService();
    }
}
