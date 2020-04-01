import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CotizarmonedaComponent } from './cotizarmoneda.component';

describe('CotizarmonedaComponent', () => {
  let component: CotizarmonedaComponent;
  let fixture: ComponentFixture<CotizarmonedaComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CotizarmonedaComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CotizarmonedaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
