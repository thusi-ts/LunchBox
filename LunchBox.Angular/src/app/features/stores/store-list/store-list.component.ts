import { CommonModule } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { Store } from '@core/models/store';
import { StoreService } from '@core/services/store.service';
import {  StoreItemComponent } from '@features/stores/store-item/store-item.component';
import { FlexLayoutModule } from "@angular/flex-layout";

@Component({
  selector: 'store-list',
  standalone: true,
  imports: [FlexLayoutModule, CommonModule, StoreItemComponent],
  template: `
    <div fxLayout="row wrap" fxLayout.lt-sm="column" fxLayoutGap="32px" fxLayoutAlign="flex-start">
      <ng-container *ngFor="let store of stores">
        <store-item fxFlex="0 1 calc(50% - 32px)" fxFlex.lt-sm="100%" [store]="store"></store-item> <!-- 3 colums fxFlex="0 1 calc(50% - 32px)" -->
      </ng-container>
    </div>
      `,
  styles: [`
    
  `]
})
export class StoreListComponent implements OnInit {
  stores: Store[] = [];
  
  constructor(private storeService: StoreService) {
  }

  ngOnInit(): void {
    this.storeService.getStores().subscribe((data: Store[]) => {
      this.stores = data;
    });
  }
}
