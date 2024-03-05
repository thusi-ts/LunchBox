import { Routes } from '@angular/router';
import { HomeComponent } from './features/home/home.component';
import { InfoComponent } from './features/info/info.component';
import { MyaccountComponent } from './features/myaccount/myaccount.component';
import { PagenotfountComponent } from './features/pagenotfount/pagenotfount.component';

export const routes: Routes = [
    {path: '', component: HomeComponent},
    {path: 'info', component: InfoComponent},
    {path: 'user', component: MyaccountComponent},
    {path: '**', 'title': 'Home', component: PagenotfountComponent}
];
