using EZCode.ProductService.Localization;
using Volo.Abp.AspNetCore.Components;

namespace EZCode.ProductService.Blazor.Server.Host;

public abstract class ProductServiceComponentBase : AbpComponentBase
{
    protected ProductServiceComponentBase()
    {
        LocalizationResource = typeof(ProductServiceResource);
    }
}
