using EZCode.ProductService.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace EZCode.ProductService.Permissions;

public class ProductServicePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ProductServicePermissions.GroupName, L("Permission:ProductService"));

        var productPermission = myGroup.AddPermission(ProductServicePermissions.Products.Default, L("Permission:Products"));
        productPermission.AddChild(ProductServicePermissions.Products.Create, L("Permission:Create"));
        productPermission.AddChild(ProductServicePermissions.Products.Update, L("Permission:Update"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ProductServiceResource>(name);
    }
}
