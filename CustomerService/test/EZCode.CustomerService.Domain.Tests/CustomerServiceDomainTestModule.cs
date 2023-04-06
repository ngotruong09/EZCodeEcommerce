using EZCode.CustomerService.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace EZCode.CustomerService;

[DependsOn(
    typeof(CustomerServiceEntityFrameworkCoreTestModule)
    )]
public class CustomerServiceDomainTestModule : AbpModule
{

}
