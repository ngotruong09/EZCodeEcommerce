using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;

namespace EZCode.ProductService.Products
{
    [Area(ProductServiceRemoteServiceConsts.ModuleName)]
    [RemoteService(Name = ProductServiceRemoteServiceConsts.RemoteServiceName)]
    [Route("api/product-service/products")]
    public class ProductController : ProductServiceController, IProductAppService
    {
        private readonly IProductAppService _service;

        public ProductController(IProductAppService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("get-list")]
        public Task<PagedResultDto<ProductDto>> GetListAsync(GetProductsInput request)
        {
            return _service.GetListAsync(request);
        }

        [HttpPost]
        [Route("create")]
        public Task<ProductDto> CreateAsync(CreateProductInput request)
        {
            return _service.CreateAsync(request);
        }
    }
}
