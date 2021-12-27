import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PagedIngredientsComponent } from './paged-ingredients.component';

describe('PagedIngredientsComponent', () => {
  let component: PagedIngredientsComponent;
  let fixture: ComponentFixture<PagedIngredientsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PagedIngredientsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PagedIngredientsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
