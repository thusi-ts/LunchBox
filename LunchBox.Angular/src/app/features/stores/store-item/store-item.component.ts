import { Component, Input } from '@angular/core';
import { FlexLayoutModule } from '@angular/flex-layout';
import { Store } from '@core/models/store';
import { RouterLink } from '@angular/router';

@Component({
  selector: 'store-item',
  standalone: true,
  imports: [FlexLayoutModule, RouterLink],
  template: `
    <div fxLayout="row" fxLayoutAlign="start start">
      <div fxLayoutAlign="start start" class="company-link"><a routerLink="/store"><img src="https://www.lunchbox.dk/assets/images/company/kc.png"></a></div>
      <div fxLayoutAlign="start start" class="">
        <div class="company-content">
          <h4 class="company-title">
            <a class="company-link" routerLink="/store">{{ store.name }}</a>
          </h4>
          <div class="address">{{ store.address }}</div>
        </div>
      </div>
    </div>
      `,
  styles: [`
    .company-thumb {
      width: 100px;
      height: 100px;
      background-repeat: no-repeat;
      background-size: cover;
      border-right: 6px solid #005984;
    }
    
    .company-title {
      font-size: 14px;
      color: #333;
      margin: 0 !important;
      white-space: nowrap;
      text-overflow: ellipsis;
      overflow: hidden;
      font-weight: bold;
    }
    
    .company-content {
      margin-left: 12px;
      text-align: left;
    }
    
    .company-content .any-desc {
      font-size: 12px;
      height: 33px;
      text-overflow: ellipsis;
      font-weight: normal;
      margin-bottom: 10px;
      color: black;
    }
    
    .company-content .address {
      font-size: 14px;
      font-weight: normal;
      color: black;
      overflow: hidden;
      text-overflow: ellipsis;
      white-space: nowrap;
    }

    .company-link { 
      color: #333;
      text-decoration: none; 
    } 
  `]
})
export class StoreItemComponent {
  @Input() store!: Store;

  constructor() {
  }
}
