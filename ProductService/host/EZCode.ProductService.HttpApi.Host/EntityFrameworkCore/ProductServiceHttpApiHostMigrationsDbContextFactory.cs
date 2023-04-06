using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace EZCode.ProductService.EntityFrameworkCore;

public class ProductServiceHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<ProductServiceHttpApiHostMigrationsDbContext>
{
    public ProductServiceHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<ProductServiceHttpApiHostMigrationsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("ProductService"));

        return new ProductServiceHttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
