import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LbCarouselComponent } from './lb-carousel.component';

describe('LbCarouselComponent', () => {
  let component: LbCarouselComponent;
  let fixture: ComponentFixture<LbCarouselComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [LbCarouselComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(LbCarouselComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
