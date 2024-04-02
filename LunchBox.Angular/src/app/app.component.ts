import { Component, OnInit, ViewContainerRef, ViewChild } from '@angular/core';
import { BreakpointObserver, Breakpoints,  } from '@angular/cdk/layout';
import { distinctUntilChanged, tap } from 'rxjs/operators';
import { MobileComponent } from './core/layouts/mobile.component';
import { DefaultComponent } from './core/layouts/default.component';

@Component({
  selector: 'app-root',
  template: `<ng-container #appLayout></ng-container>`,
  standalone: true,
  imports: [ DefaultComponent, MobileComponent],
})

export class AppComponent implements OnInit {

  lunchbox:any = {
    mobileDevice: false,
  }
  currentBreakpoint:string = '(max-width: 700px)';
  
  constructor(private viewContainerRef: ViewContainerRef, private breakpointObserver: BreakpointObserver) { }

  readonly breakpoint$ = this.breakpointObserver
    .observe([this.currentBreakpoint])
    .pipe( tap(value => this.lunchbox.mobileDevice = value.matches), // tab the output
    distinctUntilChanged());

  ngOnInit():void{
    this.breakpoint$.subscribe(() => 
        this.breakpointChanged()
    );
  }

  private breakpointChanged(){
    this.viewContainerRef.clear();
    if(this.breakpointObserver.isMatched(this.currentBreakpoint)){
      const containerRef = this.viewContainerRef.createComponent(MobileComponent); 
      const dynamicComponent = containerRef.instance as MobileComponent;
      dynamicComponent.data = this.lunchbox;
    } else {
      const containerRef = this.viewContainerRef.createComponent(DefaultComponent);
      const dynamicComponent = containerRef.instance as DefaultComponent;
      dynamicComponent.data = this.lunchbox;
    }    
  }
}