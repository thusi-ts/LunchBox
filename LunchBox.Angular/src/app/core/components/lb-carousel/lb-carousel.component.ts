import { NgStyle, NgClass } from '@angular/common';
import { Component, Input, OnInit } from '@angular/core';
import {FlexLayoutServerModule} from '@angular/flex-layout/server';
import { interval, timeout } from 'rxjs';

@Component({
  selector: 'lb-carousel',
  imports: [FlexLayoutServerModule, NgStyle, NgClass],
  standalone: true,
  templateUrl: './lb-carousel.component.html',
  styleUrls: ['./lb-carousel.component.css']
})
export class LbCarouselComponent implements OnInit {

  constructor() { }

  currentSlide = 0;
  @Input() slides: any[] = [];
  @Input() autoPlay: boolean = true;
  @Input() indicatorVisible:boolean = false;
  @Input() showTitle:boolean = false;

  ngOnInit() { 
    this.autoplay();
  }

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

  autoplay(){
    if(this.autoPlay){
      const lbinterval = interval(4000);
      lbinterval.subscribe(val => {
        this.next()
      });
    }
  }
}