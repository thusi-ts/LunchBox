import { Component } from '@angular/core';
import { FlexLayoutModule } from '@angular/flex-layout';

@Component({
  selector: 'app-menu',
  standalone: true,
  imports: [FlexLayoutModule],
  template: `
  <div class="menu" fxLayoutAlign="center stretch">
  <div class="main" fxFlex="100" fxFlex.gt-sm="940px" fxLayout="row" fxLayoutAlign="end center" >
    <div class="menu" fxLayout="row">
      <div fxLayoutAlign="end center" class="item menu-item"><a routerLink="/">Find  mad</a></div>
      <div fxLayoutAlign="end center" class="item menu-item"><a routerLink="/">Info</a></div>
      <div fxLayoutAlign="end center" class="item menu-item"><a routerLink="/">Min konto</a></div>
    </div>
  </div>
</div>
    `,
  styles: [`
    
  `]
})
export class MenuComponent {

  showLoader(){

    alert("Test");

  }
}
