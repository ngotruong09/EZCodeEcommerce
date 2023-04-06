using System.Threading.Tasks;

namespace EZCode.CustomerService.Data;

public interface ICustomerServiceDbSchemaMigrator
{
    Task MigrateAsync();
}
