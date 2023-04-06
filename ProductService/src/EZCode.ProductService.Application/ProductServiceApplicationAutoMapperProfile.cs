using AutoMapper;
using EZCode.ProductService.Products;
using System;
using Volo.Abp.AutoMapper;

namespace EZCode.ProductService;

public class ProductServiceApplicationAutoMapperProfile : Profile
{
    public ProductServiceApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

        CreateMap<Product, ProductDto>();
        CreateMap<CreateProductInput, Product>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => Guid.NewGuid().ToString()));
        CreateMap<ProductUpdateDto, Product>()
           .Ignore(x => x.Id);
    }
}
