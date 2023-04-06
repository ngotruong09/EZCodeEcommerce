using Volo.Abp.Modularity;

namespace EZCode.CustomerService;

[DependsOn(
    typeof(CustomerServiceApplicationModule),
    typeof(CustomerServiceDomainTestModule)
    )]
public class CustomerServiceApplicationTestModule : AbpModule
{

}
