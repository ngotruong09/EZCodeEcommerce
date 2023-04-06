using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace EZCode.ProductService;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ProductServiceHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class ProductServiceConsoleApiClientModule : AbpModule
{

}
