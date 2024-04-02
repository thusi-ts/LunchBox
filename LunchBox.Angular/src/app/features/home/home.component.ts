import { Component } from '@angular/core';
import { FlexLayoutModule } from '@angular/flex-layout';
import { LbCarouselComponent } from '../../core/components/lb-carousel/lb-carousel.component';

@Component({
  selector: 'app-home',
  standalone: true,
  imports: [ FlexLayoutModule, LbCarouselComponent],
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})
export class HomeComponent {
  
  slides: any[] = [
    {
      url: "https://images.unsplash.com/photo-1707343843344-011332037abb?q=80&w=2070&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDF8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
      title: "test 1",
      description: "Pascal van de Vendel 1",
    },
    {
      url: "https://plus.unsplash.com/premium_photo-1705091309202-5838aeedd653?q=80&w=1974&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
      title: "",
      description: "Pascal van de Vendel 2",
    },
    {
      url: "https://images.unsplash.com/photo-1709274296402-f6e96caaa1eb?q=80&w=1932&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
      title: "test 3",
      description: "Pascal van de Vendel 3",
    },
    {
      url: "https://images.unsplash.com/photo-1682687220161-e3e7388e4fad?q=80&w=2070&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDF8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
      title: "test 4",
      description: "Pascal van de Vendel 4",
    },
    {
      url: "https://images.unsplash.com/photo-1708886383759-fb23c24db348?q=80&w=2070&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
      title: "test 5",
      description: "Pascal van de Vendel 5",
    }

  ];
}
