using Volo.Abp.AspNetCore.Components.Server.Theming;
using Volo.Abp.Modularity;

namespace EZCode.ProductService.Blazor.Server;

[DependsOn(
    typeof(AbpAspNetCoreComponentsServerThemingModule),
    typeof(ProductServiceBlazorModule)
    )]
public class ProductServiceBlazorServerModule : AbpModule
{

}
