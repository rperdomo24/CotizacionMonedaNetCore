import { TestBed } from '@angular/core/testing';

import { CotizarmonedaService } from './cotizarmoneda.service';

describe('CotizarmonedaService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: CotizarmonedaService = TestBed.get(CotizarmonedaService);
    expect(service).toBeTruthy();
  });
});
