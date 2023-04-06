using EZCode.CustomerService.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace EZCode.CustomerService.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class CustomerServiceController : AbpControllerBase
{
    protected CustomerServiceController()
    {
        LocalizationResource = typeof(CustomerServiceResource);
    }
}
