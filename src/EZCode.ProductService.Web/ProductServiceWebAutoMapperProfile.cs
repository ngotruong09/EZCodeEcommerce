using AutoMapper;
using EZCode.ProductService.Products;
using EZCode.ProductService.Web.Pages.ProductService.Products;

namespace EZCode.ProductService.Web;

public class ProductServiceWebAutoMapperProfile : Profile
{
    public ProductServiceWebAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<ProductDto, ProductUpdateViewModel>();
        CreateMap<ProductUpdateViewModel, ProductUpdateDto>();
    }
}
