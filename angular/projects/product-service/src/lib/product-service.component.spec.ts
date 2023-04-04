import { ComponentFixture, TestBed, waitForAsync } from '@angular/core/testing';

import { ProductServiceComponent } from './product-service.component';

describe('ProductServiceComponent', () => {
  let component: ProductServiceComponent;
  let fixture: ComponentFixture<ProductServiceComponent>;

  beforeEach(waitForAsync(() => {
    TestBed.configureTestingModule({
      declarations: [ ProductServiceComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ProductServiceComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
