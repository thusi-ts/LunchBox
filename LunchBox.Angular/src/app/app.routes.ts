import { Routes } from '@angular/router';
import { HomeComponent } from '@features/home/home.component';
import { InfoComponent } from '@features/info/info.component';
import { LoginComponent } from '@features/user/login/login.component';
import {  StoreComponent } from '@features/stores/store/store.component';
import { PagenotfountComponent } from '@features/pagenotfount/pagenotfount.component';
import { authGuard } from '@core/services/guards/auth.guard';

export const routes: Routes = [
    {path: '', component: HomeComponent, canActivate: [authGuard]},
    {path: 'info', component: InfoComponent},
    {path: 'user/login', component: LoginComponent},
    {path: 'store', component: StoreComponent, canActivate: [authGuard]},
    {path: '**', 'title': 'Home', component: PagenotfountComponent}
];
