/* This file is automatically generated by ABP framework to use MVC Controllers from javascript. */


// module productService

(function(){

  // controller eZCode.productService.samples.sample

  (function(){

    abp.utils.createNamespace(window, 'eZCode.productService.samples.sample');

    eZCode.productService.samples.sample.get = function(ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/ProductService/sample',
        type: 'GET'
      }, ajaxParams));
    };

    eZCode.productService.samples.sample.getAuthorized = function(ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/ProductService/sample/authorized',
        type: 'GET'
      }, ajaxParams));
    };

  })();

  // controller eZCode.productService.products.product

  (function(){

    abp.utils.createNamespace(window, 'eZCode.productService.products.product');

    eZCode.productService.products.product.getList = function(request, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/product-service/products/get-list' + abp.utils.buildQueryString([{ name: 'name', value: request.name }, { name: 'description', value: request.description }, { name: 'priceMin', value: request.priceMin }, { name: 'priceMax', value: request.priceMax }]) + '',
        type: 'GET'
      }, ajaxParams));
    };

    eZCode.productService.products.product.create = function(request, ajaxParams) {
      return abp.ajax($.extend(true, {
        url: abp.appPath + 'api/product-service/products/create',
        type: 'POST',
        data: JSON.stringify(request)
      }, ajaxParams));
    };

  })();

})();

