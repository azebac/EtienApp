import { TestBed } from '@angular/core/testing';

import { NavigationParamsService } from './navigation-params.service';

describe('NavigationParamsService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: NavigationParamsService = TestBed.get(NavigationParamsService);
    expect(service).toBeTruthy();
  });
});
