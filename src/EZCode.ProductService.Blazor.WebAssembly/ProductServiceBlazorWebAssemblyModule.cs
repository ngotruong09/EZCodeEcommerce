using Volo.Abp.AspNetCore.Components.WebAssembly.Theming;
using Volo.Abp.Modularity;

namespace EZCode.ProductService.Blazor.WebAssembly;

[DependsOn(
    typeof(ProductServiceBlazorModule),
    typeof(ProductServiceHttpApiClientModule),
    typeof(AbpAspNetCoreComponentsWebAssemblyThemingModule)
    )]
public class ProductServiceBlazorWebAssemblyModule : AbpModule
{

}
