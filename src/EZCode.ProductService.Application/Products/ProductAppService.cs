using EZCode.ProductService.Permissions;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace EZCode.ProductService.Products
{
    [Authorize(ProductServicePermissions.Products.Default)]
    public class ProductAppService : ProductServiceAppService, IProductAppService
    {
        private readonly IProductRepository _productRepository;

        public ProductAppService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [Authorize(ProductServicePermissions.Products.Create)]
        public async Task<ProductDto> CreateAsync(CreateProductInput request)
        {
            var entity = ObjectMapper.Map<CreateProductInput, Product>(request);
            entity = await _productRepository.InsertAsync(entity);
            return ObjectMapper.Map<Product, ProductDto>(entity);
        }

        [Authorize(ProductServicePermissions.Products.Delete)]
        public async Task DeleteAsync(Guid id)
        {
            await _productRepository.DeleteAsync(x=> x.Id == id);
        }

        public async Task<ProductDto> GetAsync(Guid id)
        {
            var product = await _productRepository.GetAsync(x=>x.Id == id);
            return ObjectMapper.Map<Product, ProductDto>(product);
        }

        public async Task<PagedResultDto<ProductDto>> GetListAsync(GetProductsInput request)
        {
            var queryable = await _productRepository.GetQueryableAsync();
            queryable
                .WhereIf(!string.IsNullOrEmpty(request.Name), x => x.Name.Contains(request.Name))
                .WhereIf(!string.IsNullOrEmpty(request.Description), x => x.Name.Contains(request.Description))
                .WhereIf(request.PriceMin.HasValue, x => x.Price >= request.PriceMin.Value)
                .WhereIf(request.PriceMax.HasValue, x => x.Price <= request.PriceMax.Value);

            var data = await AsyncExecuter.ToListAsync(queryable);  

            var res = new PagedResultDto<ProductDto>
            {
                TotalCount = data.Count,
                Items = ObjectMapper.Map<List<Product>, List<ProductDto>>(data)
            };

            return res;
        }

        [Authorize(ProductServicePermissions.Products.Update)]
        public async Task<ProductDto> UpdateAsync(Guid id, ProductUpdateDto input)
        {
            var product = await _productRepository.GetAsync(x=>x.Id == id);
            var productUpdate = ObjectMapper.Map(input, product);
            productUpdate = await _productRepository.UpdateAsync(productUpdate);
            return ObjectMapper.Map<Product, ProductDto>(productUpdate);
        }
    }
}
