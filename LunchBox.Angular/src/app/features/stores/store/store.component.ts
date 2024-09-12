import { Component } from '@angular/core';
import { RouterLink } from '@angular/router';
import { FlexLayoutModule } from '@angular/flex-layout';

@Component({
  selector: 'app-store',
  standalone: true,
  imports: [RouterLink, FlexLayoutModule],
  templateUrl: './store.component.html',
  styleUrl: './store.component.css'
})
export class StoreComponent {

}
