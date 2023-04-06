using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace EZCode.ProductService.Products
{
    public interface IProductAppService: IApplicationService
    {
        Task<PagedResultDto<ProductDto>> GetListAsync(GetProductsInput request);
        Task<ProductDto> CreateAsync(CreateProductInput request);
        Task<ProductDto> UpdateAsync(Guid id, ProductUpdateDto input);
        Task<ProductDto> GetAsync(Guid id);
        Task DeleteAsync(Guid id);
    }
}
