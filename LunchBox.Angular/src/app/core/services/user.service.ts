import { Injectable } from '@angular/core';
import { environment } from '@environment/environment';
import { HttpClient, HttpErrorResponse, HttpResponse } from '@angular/common/http';
import { User } from '@core/models/user';
import {BehaviorSubject, catchError, map, Observable, throwError} from 'rxjs';
import { JwtHelperService } from '@auth0/angular-jwt';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  public apiUrl = environment.apiUrl;
  private jwtHelper = new JwtHelperService();
  currentUser = new BehaviorSubject<User>({});

  constructor(private httpClient: HttpClient) { 
  }

  login(user: User) : Observable<HttpResponse<User>> {
    return this.httpClient.post<User>(`${this.apiUrl}/api/Token`, user, {observe: 'response'}).pipe(
      map((response: HttpResponse<User>) => {
          const userRenponse: User = response.body ? response.body : {};
          this.currentUser.next(userRenponse);
          return response;
        }),
        catchError((error: HttpErrorResponse) => {
          console.error('Login failed:', error.message);
          return throwError(() => new Error('Login failed, please try again later.'));
      })
    );
  }
   
  addUserToCache(user: User): void {
   localStorage.setItem('lbUser', JSON.stringify(user))
  }
   
  getUserFromCache(): User {
   return JSON.parse(localStorage.getItem('lbUser') || '');
  }
   
  addTokenToCache(token: string): void {
   localStorage.setItem('lbUserToken', token);
  }
   
  getTokenFromCache(): string {
    try {
      return localStorage.getItem('lbUserToken') || '';
    } catch (error) {
      return '';
    }
   
  }

  logOut(): void {
    try {
      this.currentUser.next({});
      localStorage.removeItem('lbUserToken');
      localStorage.removeItem('lbUser');
      sessionStorage.clear();
    } catch (error) {
    }
  }
   
  isUserLoggedIn(): Boolean {
   if(this.getTokenFromCache() && this.jwtHelper.decodeToken(this.getTokenFromCache()) && !this.jwtHelper.isTokenExpired(this.getTokenFromCache())) {
    this.currentUser.next(this.getUserFromCache());
    return true; 
   } else {
    this.logOut();
    return false;
   }
  }
}
