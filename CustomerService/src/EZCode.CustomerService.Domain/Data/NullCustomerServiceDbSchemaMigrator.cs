using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace EZCode.CustomerService.Data;

/* This is used if database provider does't define
 * ICustomerServiceDbSchemaMigrator implementation.
 */
public class NullCustomerServiceDbSchemaMigrator : ICustomerServiceDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
