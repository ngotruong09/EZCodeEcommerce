using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using EZCode.CustomerService.Data;
using Volo.Abp.DependencyInjection;

namespace EZCode.CustomerService.EntityFrameworkCore;

public class EntityFrameworkCoreCustomerServiceDbSchemaMigrator
    : ICustomerServiceDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreCustomerServiceDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the CustomerServiceDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<CustomerServiceDbContext>()
            .Database
            .MigrateAsync();
    }
}
