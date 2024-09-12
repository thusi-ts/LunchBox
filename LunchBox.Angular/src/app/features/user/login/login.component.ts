import { Component, OnInit  } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormGroup, FormControl, ReactiveFormsModule, Validators } from '@angular/forms';
import { MatCardModule } from '@angular/material/card';
import { FlexLayoutModule } from '@angular/flex-layout';
import {MatInputModule} from '@angular/material/input';
import {MatButtonModule} from '@angular/material/button';
import {MatFormFieldModule} from '@angular/material/form-field';
import {FormsModule} from '@angular/forms';
import { User } from '@core/models/user'; 
import { UserService } from '@core/services/user.service';
import { Router } from '@angular/router';
import { HttpResponse, HttpErrorResponse } from '@angular/common/http';
import { FlexLayoutServerModule } from '@angular/flex-layout/server';

@Component({
  selector: 'app-login',
  standalone: true,
  imports: [ CommonModule, MatCardModule, ReactiveFormsModule, FlexLayoutModule, FlexLayoutServerModule, FormsModule, MatFormFieldModule, MatInputModule, MatButtonModule],
  template: `
      <div class="content" fxLayoutAlign="center stretch">
        <div class="main" fxFlex="100" fxFlex.gt-sm="940px" fxLayout="column" fxLayoutAlign="space-between stretch">
          <div div fxLayout="column" fxLayoutAlign="center center" class="content">
            <mat-card class="form">
            <mat-card-title class="title">Login</mat-card-title>
              <form [formGroup]="loginform" class="login-form" (ngSubmit)="onSubmit(this.loginform.value)">
              
                <mat-form-field>
                  <mat-label>Username</mat-label>
                  <input matInput value="email" name="username" placeholder="" formControlName="username" required>
                  <div class="text-danger" *ngIf="loginform.controls['username'].invalid && (loginform.controls['username'].touched || loginform.controls['username'].dirty)">
                    <span *ngIf="loginform.controls['username'].errors?.['required']">Please enter a valid username</span>
                    <span *ngIf="loginform.controls['username'].errors?.['email']">Please enter a valid email</span>
                  </div> 
                </mat-form-field>

                <mat-form-field>
                  <mat-label>Password</mat-label>
                  <input type="password" matInput name="password" placeholder="" formControlName="password" required>
                  <div class="text-danger" *ngIf="loginform.controls['password'].invalid && (loginform.controls['password'].touched || loginform.controls['password'].dirty)">
                    <span *ngIf="loginform.controls['username'].errors?.['required']">Please enter a password</span>
                  </div> 
                </mat-form-field>

                <mat-card-actions>
                  <button [disabled]="showLoading ? true : null" mat-raised-button color="primary" type="submit">
                    <span *ngIf="showLoading">Loading ....</span>
                    <span *ngIf="!showLoading">Login</span>
                  </button>
                </mat-card-actions>

              </form>
            </mat-card>
          </div>
        </div>
      </div>
    `,
  styles: [`
    .form {
      min-height: 300px;
      min-width: 350px;
      margin: 20px;
      padding: 20px;
      box-sizing: border-box;
    }

    .mat-mdc-form-field {
      width: 100%;
    }

    .title{
      text-align: center;
      margin-bottom: 40px;
    }

    .form-group {
      padding-top: 20px;
      padding-bottom: 20px;
    }
  `]
})

export class LoginComponent implements OnInit {

  loginform: FormGroup;
  showLoading: Boolean = false;

  constructor(private userService: UserService, private router: Router) {
    this.loginform = new FormGroup({
      username: new FormControl("visitor@hotmail.com", [Validators.required, Validators.email]),
      password: new FormControl("Visitor!23", [Validators.required]),
    })
  }

  onSubmit(user: User): void {
    this.showLoading = true;
    const isFormValid = this.loginform.valid;
    if(isFormValid){
      
      this.userService.login(user).subscribe({
        next: (response: HttpResponse<User>) => {
          this.userService.addTokenToCache(response.body?.token || '');
          this.userService.addUserToCache(response.body || {});
          this.router.navigateByUrl('/');
          this.showLoading = false;
        },

        error: (error: HttpErrorResponse) => {
          alert(error.message);
          this.showLoading = false;
        },

        complete() {
        },
      });
    }
  }

  ngOnInit(): void {
    this.userService.logOut();
    this.router.navigateByUrl('/user/login');
  }
}
