import { Component } from '@angular/core';
import { RouterLink } from '@angular/router';
import { FlexLayoutModule } from '@angular/flex-layout';
import {FlexLayoutServerModule} from '@angular/flex-layout/server';


@Component({
  selector: 'app-menu',
  standalone: true,
  imports: [RouterLink, FlexLayoutServerModule, FlexLayoutModule],
  template: `
  <div fxLayoutAlign="center stretch">
    <div class="main" fxFlex="100" fxFlex.gt-sm="940px" fxLayout="row" fxLayoutAlign="end center" >
      <div class="menu" fxLayout="row" >
        <div class="menu-item" fxFlexAlign="center"><a routerLink="/">Find  mad</a></div>
        <div class="menu-item" fxFlexAlign="center"><a routerLink="/info">Info</a></div>
        <div class="menu-item" fxFlexAlign="center"><a routerLink="/">Min konto</a></div>
      </div>
    </div>
  </div>
  `,
  styles: [`
    .menu{
    height: 36px;
    background-color: #4caf50;
  }
  
  .menu-item{
    padding: 0 8px;
    color: #ffffff;
    background-color: #4caf50;
  }

  .menu-item a{
    padding: 6px 12px 6px 12px;
    color: #ffffff;
    text-decoration: none;
  }
  
  .menu-item a:hover{
    color: #ffffff;
    background-color: #5cdd61;
  }
    
  `]
})
export class MenuComponent {
}
