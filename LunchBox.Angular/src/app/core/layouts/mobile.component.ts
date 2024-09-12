import { Component, Input, OnInit} from '@angular/core';
import { CommonModule } from '@angular/common';
import {MatToolbarModule} from '@angular/material/toolbar';
import { RouterOutlet } from '@angular/router';
import { HeaderComponent } from '@core/components/header.component';
import { MenuComponent } from '@core/components/menu.component';

@Component({
  selector: 'app-mobile',
  standalone: true,
  imports: [CommonModule, HeaderComponent, MenuComponent, RouterOutlet, MatToolbarModule],
  template: `
    <div class="mobile-layout">
      <app-header></app-header>
      <router-outlet #routerOutlet></router-outlet>
      <app-menu></app-menu>
    </div>
    `,
  styles: [`
  `],
})
export class MobileComponent implements OnInit {
  @Input() data: any;

  ngOnInit(): void {
  }
}
