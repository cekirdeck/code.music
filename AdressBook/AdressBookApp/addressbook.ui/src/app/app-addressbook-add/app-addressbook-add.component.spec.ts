import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AppAddressbookAddComponent } from './app-addressbook-add.component';

describe('AppAddressbookAddComponent', () => {
  let component: AppAddressbookAddComponent;
  let fixture: ComponentFixture<AppAddressbookAddComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [AppAddressbookAddComponent]
    });
    fixture = TestBed.createComponent(AppAddressbookAddComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
