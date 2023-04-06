using Volo.Abp.Bundling;

namespace EZCode.ProductService.Blazor.Host;

public class ProductServiceBlazorHostBundleContributor : IBundleContributor
{
    public void AddScripts(BundleContext context)
    {

    }

    public void AddStyles(BundleContext context)
    {
        context.Add("main.css", true);
    }
}
