using EZCode.ProductService.Products;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace EZCode.ProductService.EntityFrameworkCore;

public static class ProductServiceDbContextModelCreatingExtensions
{
    public static void ConfigureProductService(
        this ModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));

        builder.Entity<Product>(b =>
        {
            b.ToTable(ProductServiceDbProperties.DbTablePrefix + "Product", ProductServiceDbProperties.DbSchema);
            b.ConfigureByConvention();
            b.Property(x=> x.Name).HasColumnName("Name");
            b.Property(x=>x.Description).HasColumnName("Description");
            b.Property(x => x.Price).HasColumnName("Price");
        });
    }
}
