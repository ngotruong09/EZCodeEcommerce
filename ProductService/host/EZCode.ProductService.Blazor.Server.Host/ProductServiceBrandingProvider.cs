using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace EZCode.ProductService.Blazor.Server.Host;

[Dependency(ReplaceServices = true)]
public class ProductServiceBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "ProductService";
}
