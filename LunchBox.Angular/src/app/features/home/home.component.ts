import { Component } from '@angular/core';
import { FlexLayoutModule } from '@angular/flex-layout';
import { LbCarouselComponent } from '@core/components/lb-carousel/lb-carousel.component';
import { StoreListComponent } from "@features/stores/store-list/store-list.component";

@Component({
  selector: 'app-home',
  standalone: true,
  imports: [FlexLayoutModule, LbCarouselComponent, StoreListComponent],
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})
export class HomeComponent {
  
  slides: any[] = [
    {
      url: "https://lunchbox.dk/assets/images/news-slider/slide1.png",
      title: "test 1",
      description: "Pascal van de Vendel 1",
    },
    {
      url: "https://www.lunchbox.dk/assets/images/news-slider/slide2.jpg",
      title: "test 2",
      description: "Pascal van de Vendel 2",
    },
  ];
}
