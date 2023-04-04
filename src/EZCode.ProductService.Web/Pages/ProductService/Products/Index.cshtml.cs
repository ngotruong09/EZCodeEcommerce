using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace EZCode.ProductService.Web.Pages.ProductService.Products
{
    public class IndexModel : AbpPageModel
    {
        public async Task OnGetAsync()
        {
            await Task.CompletedTask;
        }
    }
}