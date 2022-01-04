import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AngularMaterialPaginationComponent } from './angular-material-pagination.component';

describe('AngularMaterialPaginationComponent', () => {
  let component: AngularMaterialPaginationComponent;
  let fixture: ComponentFixture<AngularMaterialPaginationComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AngularMaterialPaginationComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AngularMaterialPaginationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
