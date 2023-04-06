using System;
using System.Collections.Generic;
using System.Text;
using EZCode.CustomerService.Localization;
using Volo.Abp.Application.Services;

namespace EZCode.CustomerService;

/* Inherit your application services from this class.
 */
public abstract class CustomerServiceAppService : ApplicationService
{
    protected CustomerServiceAppService()
    {
        LocalizationResource = typeof(CustomerServiceResource);
    }
}
