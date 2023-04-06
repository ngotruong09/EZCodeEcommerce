using EZCode.ProductService.Products;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using Volo.Abp.ObjectMapping;

namespace EZCode.ProductService.Web.Pages.ProductService.Products
{
    public class ProductUpdateViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
    public class EditModalModel : ProductServicePageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public ProductUpdateViewModel ProductUpdateDto { get; set; }

        private readonly IProductAppService _service;

        public EditModalModel(IProductAppService service)
        {
            _service = service;
        }

        public async Task OnGet()
        {
            var product = await _service.GetAsync(Id);
            ProductUpdateDto = ObjectMapper.Map<ProductDto, ProductUpdateViewModel>(product);
        }
        public async Task<NoContentResult> OnPostAsync()
        {
            await _service.UpdateAsync(Id, ObjectMapper.Map<ProductUpdateViewModel, ProductUpdateDto>(ProductUpdateDto));
            return NoContent();
        }
    }
}
