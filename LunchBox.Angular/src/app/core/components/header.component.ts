import { Component } from '@angular/core';
import { FlexLayoutModule } from '@angular/flex-layout';

@Component({
  selector: 'app-header',
  standalone: true,
  imports: [FlexLayoutModule],
  template: `
      <div class="header" fxLayoutAlign="center stretch">
        <div class="main" fxFlex="100" fxFlex.gt-sm="940px" fxLayout="row" fxLayoutAlign="space-between stretch" >
          <div fxLayoutAlign="start center" class="logo"><a routerLink=""><img src="https://www.lunchbox.dk/assets/images/logo/white.svg"></a></div>
          <div fxLayoutAlign="end end" class="user-name">Medlem som Thusi</div>
        </div>
      </div>
    `,
  styles: [`
    .header{
    height: 124px;
    background-color: #005984;
    margin-bottom: 2px;
  }
  
  .header .logo img{
    height: 75px;
    border: 0;
    width: 290px;
    margin: 0 0 0 8px;
  }
  
  .header .user-name{
    margin: 0 16px 8px 0;
    color: #ffffff;
    font-weight: bold;
  }
  `]
})
export class HeaderComponent {
}
