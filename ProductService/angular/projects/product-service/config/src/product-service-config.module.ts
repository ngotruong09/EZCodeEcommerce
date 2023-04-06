import { ModuleWithProviders, NgModule } from '@angular/core';
import { PRODUCT_SERVICE_ROUTE_PROVIDERS } from './providers/route.provider';

@NgModule()
export class ProductServiceConfigModule {
  static forRoot(): ModuleWithProviders<ProductServiceConfigModule> {
    return {
      ngModule: ProductServiceConfigModule,
      providers: [PRODUCT_SERVICE_ROUTE_PROVIDERS],
    };
  }
}
