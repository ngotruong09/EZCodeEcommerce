using EZCode.CustomerService.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace EZCode.CustomerService.Permissions;

public class CustomerServicePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(CustomerServicePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(CustomerServicePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<CustomerServiceResource>(name);
    }
}
