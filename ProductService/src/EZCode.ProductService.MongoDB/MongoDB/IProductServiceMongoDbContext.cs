using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace EZCode.ProductService.MongoDB;

[ConnectionStringName(ProductServiceDbProperties.ConnectionStringName)]
public interface IProductServiceMongoDbContext : IAbpMongoDbContext
{
    /* Define mongo collections here. Example:
     * IMongoCollection<Question> Questions { get; }
     */
}
