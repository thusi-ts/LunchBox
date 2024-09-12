import { inject } from '@angular/core';
import { CanActivateFn, Router } from '@angular/router';
import { UserService } from '@core/services/user.service';

export const authGuard: CanActivateFn = (route, state) => {
  const userService = inject(UserService);
  const router = inject(Router);
  
  if (userService.isUserLoggedIn()) {
    return true;
  } else {
    router.navigateByUrl('/user/login');
    return false;
  }
};
