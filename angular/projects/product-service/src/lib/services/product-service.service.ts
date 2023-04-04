import { Injectable } from '@angular/core';
import { RestService } from '@abp/ng.core';

@Injectable({
  providedIn: 'root',
})
export class ProductServiceService {
  apiName = 'ProductService';

  constructor(private restService: RestService) {}

  sample() {
    return this.restService.request<void, any>(
      { method: 'GET', url: '/api/ProductService/sample' },
      { apiName: this.apiName }
    );
  }
}
