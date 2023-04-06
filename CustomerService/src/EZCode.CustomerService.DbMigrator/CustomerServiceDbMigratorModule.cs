using EZCode.CustomerService.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace EZCode.CustomerService.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(CustomerServiceEntityFrameworkCoreModule),
    typeof(CustomerServiceApplicationContractsModule)
    )]
public class CustomerServiceDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
