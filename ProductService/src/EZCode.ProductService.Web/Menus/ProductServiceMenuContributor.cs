using EZCode.ProductService.Localization;
using EZCode.ProductService.Permissions;
using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace EZCode.ProductService.Web.Menus;

public class ProductServiceMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private async Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        var parent = await ConfigureParentMenuAsync(context);
        await ConfigureProductMenuAsync(context, parent);
    }

    // menu parent
    private Task<ApplicationMenuItem> ConfigureParentMenuAsync(MenuConfigurationContext context)
    {
        //Add main menu items.
        var menuItem = new ApplicationMenuItem(
            ProductServiceMenus.Prefix, 
            displayName: context.GetLocalizer<ProductServiceResource>()["Menu:ProductService"], 
            icon: "fa fa-globe");

        context.Menu.AddItem(menuItem);
        return Task.FromResult(menuItem);
    }

    // menu product (child)
    private static async Task ConfigureProductMenuAsync(MenuConfigurationContext context, ApplicationMenuItem parentMenu)
    {
        //Add main menu items.
        var menuItem = new ApplicationMenuItem(
            ProductServiceMenus.Products,
            displayName: context.GetLocalizer<ProductServiceResource>()["Menu:Products"],
            "/ProductService/Products",
            icon: "fa fa-globe",
            requiredPermissionName: ProductServicePermissions.Products.Default);

        parentMenu.AddItem(menuItem);
        await Task.CompletedTask;       
    }
}
