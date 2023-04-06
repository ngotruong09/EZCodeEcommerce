using Volo.Abp;
using Volo.Abp.MongoDB;

namespace EZCode.ProductService.MongoDB;

public static class ProductServiceMongoDbContextExtensions
{
    public static void ConfigureProductService(
        this IMongoModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));
    }
}
