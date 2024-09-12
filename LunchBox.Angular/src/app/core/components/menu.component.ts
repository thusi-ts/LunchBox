import { Component, OnInit } from '@angular/core';
import { RouterLink } from '@angular/router';
import { FlexLayoutModule } from '@angular/flex-layout';
import { User } from '@core/models/user'; 
import { UserService } from '@core/services/user.service';
import { CommonModule } from '@angular/common';
import { FlexLayoutServerModule } from '@angular/flex-layout/server';

@Component({
  selector: 'app-menu',
  standalone: true,
  imports: [CommonModule, RouterLink, FlexLayoutModule, FlexLayoutServerModule],
  template: `
  <div fxLayoutAlign="center stretch" class="main-wrapper">
    <div class="main" fxFlex="100" fxFlex.gt-sm="940px" fxLayout="row" fxLayoutAlign="end center" >
      <div class="menu" fxLayout="row" >
        <div class="menu-item" fxFlexAlign="center"><a routerLink="/">Find  mad</a></div>
        <div class="menu-item" fxFlexAlign="center"><a routerLink="/info">Info</a></div>
        <div *ngIf="isLogedIn" class="menu-item" fxFlexAlign="center"><a routerLink="/user/login">Log ud</a></div>
      </div>
    </div>
  </div>
  `,
  styles: [`
  .main-wrapper{
    background-color: #4caf50;
    margin-bottom: 1px;
    box-shadow: 1px 1px 10px rgba(0,0,0,0.5);
  }
  .menu{
    height: 36px;
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
export class MenuComponent implements OnInit {

  isLogedIn: Boolean = false;

  constructor(private userService: UserService) {
  }

  ngOnInit(): void {
    this.userService.currentUser.subscribe((user: User) => { 
      if (user && user.username !== undefined) this.isLogedIn = true; else this.isLogedIn = false;
    });
  }
}
