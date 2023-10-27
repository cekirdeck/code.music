import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AppAddressbookListComponent } from './app-addressbook-list.component';

describe('AppAddressbookListComponent', () => {
  let component: AppAddressbookListComponent;
  let fixture: ComponentFixture<AppAddressbookListComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [AppAddressbookListComponent]
    });
    fixture = TestBed.createComponent(AppAddressbookListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
