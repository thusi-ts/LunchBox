import { Component, Input } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { HeaderComponent } from '../components/header.component';
import { MenuComponent } from '../components/menu.component';



@Component({
  selector: 'app-default',
  standalone: true,
  imports: [HeaderComponent, MenuComponent, RouterOutlet],
  template: `
      <app-header></app-header>
      <app-menu></app-menu>
      <router-outlet #routerOutlet></router-outlet>
    `,
  styles: [`
  `],
})
export class DefaultComponent  {
  @Input() data: any;
}