using EZCode.CustomerService.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace EZCode.CustomerService.Web.Pages;

public abstract class CustomerServicePageModel : AbpPageModel
{
    protected CustomerServicePageModel()
    {
        LocalizationResourceType = typeof(CustomerServiceResource);
    }
}
