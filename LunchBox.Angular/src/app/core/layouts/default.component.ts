import { Component, Input, OnInit} from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { HeaderComponent } from '../components/header.component';
import { MenuComponent } from '../components/menu.component';

@Component({
  selector: 'app-default',
  standalone: true,
  imports: [HeaderComponent, MenuComponent, RouterOutlet],
  template: `
    <div class="default-layout">
      <app-header></app-header>
      <app-menu></app-menu>
      <router-outlet  #routerOutlet></router-outlet>
    </div>
    `,
  styles: [`
    
  `],
})
export class DefaultComponent  implements OnInit {
  @Input() data: any;

  ngOnInit(): void {
  }
}