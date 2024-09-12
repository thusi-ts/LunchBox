import { CommonModule } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { RouterLink } from '@angular/router';
import { FlexLayoutModule } from '@angular/flex-layout';
import { User } from '@core/models/user'; 
import { UserService } from '@core/services/user.service';

@Component({
  selector: 'app-header',
  standalone: true,
  imports: [CommonModule, RouterLink, FlexLayoutModule],
  template: `
      <div class="header" fxLayoutAlign="center stretch">
        <div class="main" fxFlex="100" fxFlex.gt-sm="940px" fxLayout="row" fxLayoutAlign="space-between stretch" >
          <div fxLayoutAlign="start center" class="logo"><a routerLink="/"><img src="https://www.lunchbox.dk/assets/images/logo/white.svg"></a></div>
          <div *ngIf="username" fxLayoutAlign="end end" class="user-name">Medlem som {{ username }}</div>
        </div>
      </div>
    `,
  styles: [`
    .header{
    height: 124px;
    background-color: #005984;
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
  }
  `]
})
export class HeaderComponent implements OnInit {
  username?: string = '';

  constructor(private userService: UserService) {
  }

  ngOnInit(): void {
    this.userService.currentUser.subscribe((user: User) => {
      this.username = user.username;
    });
    
  }
}
