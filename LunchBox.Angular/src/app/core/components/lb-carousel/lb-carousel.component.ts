import { NgStyle, NgClass } from '@angular/common';
import { Component, Input, OnInit, NgZone} from '@angular/core';
import { interval } from 'rxjs';

@Component({
  selector: 'lb-carousel',
  imports: [ NgStyle, NgClass],
  standalone: true,
  templateUrl: './lb-carousel.component.html',
  styleUrls: ['./lb-carousel.component.css']
})
export class LbCarouselComponent implements OnInit {

  constructor(private ngZone: NgZone) { }

  currentSlide = 0;
  @Input() slides: any[] = [];
  @Input() autoPlay:boolean = false;
  @Input() indicatorVisible:boolean = false;
  @Input() showTitle:boolean = false;

  next(){
    this.currentSlide++;
    if(this.currentSlide == this.slides.length) this.currentSlide = 0;
  }

  prev(){
    this.currentSlide--;
    if(this.currentSlide < 0) this.currentSlide = this.slides.length-1;
  }

  jumpto(index:number){
    this.currentSlide = index;
  }  

  autoRun(): void{ 
    const lbinterval$ = interval(4000);
    lbinterval$.subscribe(val => {
      this.next();
    });
  }

  ngOnInit(): void { 
    if (this.autoPlay) {
      this.autoRun();
    }
  }
}