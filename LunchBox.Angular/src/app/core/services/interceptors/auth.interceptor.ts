import { HttpInterceptorFn } from '@angular/common/http';
import { inject } from '@angular/core';
import { UserService } from '@core/services/user.service';


export const authInterceptor: HttpInterceptorFn = (req, next) => {

  const userService = inject(UserService);
  
  if(req.url.includes('/api/Token')){
    return next(req);
  }

  const token = userService.getTokenFromCache();
  const requestClone = req.clone({ setHeaders: { Authorization: `Bearer ${token}`} });
  return next(requestClone);
};
