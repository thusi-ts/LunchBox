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
    
  `]
})
export class HeaderComponent {
}
