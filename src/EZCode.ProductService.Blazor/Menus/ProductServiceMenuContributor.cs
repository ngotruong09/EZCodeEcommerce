using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace EZCode.ProductService.Blazor.Menus;

public class ProductServiceMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        //Add main menu items.
        context.Menu.AddItem(new ApplicationMenuItem(ProductServiceMenus.Prefix, displayName: "ProductService", "/ProductService", icon: "fa fa-globe"));

        return Task.CompletedTask;
    }
}
