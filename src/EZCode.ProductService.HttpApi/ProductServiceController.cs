using EZCode.ProductService.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace EZCode.ProductService;

public abstract class ProductServiceController : AbpControllerBase
{
    protected ProductServiceController()
    {
        LocalizationResource = typeof(ProductServiceResource);
    }
}
