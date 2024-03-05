import { Component, Input } from '@angular/core';
import {MatToolbarModule} from '@angular/material/toolbar';
import { RouterOutlet } from '@angular/router';
import { HeaderComponent } from '../components/header.component';
import { MenuComponent } from '../components/menu.component';

@Component({
  selector: 'app-mobile',
  standalone: true,
  imports: [HeaderComponent, MenuComponent, RouterOutlet, MatToolbarModule],
  template: `
    <mat-toolbar class="container app-default mobile" *ngIf="data.device">
      <app-header></app-header>
      <router-outlet #routerOutlet></router-outlet>
      <app-menu></app-menu>
    </mat-toolbar>
    `,
  styles: [`
  `],
})
export class MobileComponent { 
  @Input() data: any;
}
