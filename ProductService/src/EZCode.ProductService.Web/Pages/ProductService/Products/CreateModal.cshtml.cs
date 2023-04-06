using EZCode.ProductService.Products;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace EZCode.ProductService.Web.Pages.ProductService.Products
{
    public class CreateModalModel : ProductServicePageModel
    {
        private readonly IProductAppService _productAppService;

        public CreateModalModel(IProductAppService productAppService)
        {
            _productAppService = productAppService;
        }

        [BindProperty]
        public CreateProductInput Product { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _productAppService.CreateAsync(Product);
            return NoContent();
        }
    }
}
