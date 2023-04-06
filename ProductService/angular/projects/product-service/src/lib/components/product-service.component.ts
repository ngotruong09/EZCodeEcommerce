import { Component, OnInit } from '@angular/core';
import { ProductServiceService } from '../services/product-service.service';

@Component({
  selector: 'lib-product-service',
  template: ` <p>product-service works!</p> `,
  styles: [],
})
export class ProductServiceComponent implements OnInit {
  constructor(private service: ProductServiceService) {}

  ngOnInit(): void {
    this.service.sample().subscribe(console.log);
  }
}
