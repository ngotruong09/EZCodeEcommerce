import { NgModule, NgModuleFactory, ModuleWithProviders } from '@angular/core';
import { CoreModule, LazyModuleFactory } from '@abp/ng.core';
import { ThemeSharedModule } from '@abp/ng.theme.shared';
import { ProductServiceComponent } from './components/product-service.component';
import { ProductServiceRoutingModule } from './product-service-routing.module';

@NgModule({
  declarations: [ProductServiceComponent],
  imports: [CoreModule, ThemeSharedModule, ProductServiceRoutingModule],
  exports: [ProductServiceComponent],
})
export class ProductServiceModule {
  static forChild(): ModuleWithProviders<ProductServiceModule> {
    return {
      ngModule: ProductServiceModule,
      providers: [],
    };
  }

  static forLazy(): NgModuleFactory<ProductServiceModule> {
    return new LazyModuleFactory(ProductServiceModule.forChild());
  }
}
