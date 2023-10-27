import { Component } from '@angular/core';
import { PersonData } from '../app-addressbook-list/person-data';
import { AddressBookService } from '../address-book.service';

@Component({
  selector: 'app-addressbook-add',
  templateUrl: './app-addressbook-add.component.html',
  styleUrls: ['./app-addressbook-add.component.css']
})
export class AppAddressbookAddComponent {
  person: PersonData = {
    address: '',
    company: '',
    email: '',
    id: -1,
    name: '',
    phone: '',
    surname: '',
  };
  constructor(private adrService: AddressBookService) {
  }
  addPerson() {
    this.adrService.addPerson(this.person).subscribe({
      next: (data: PersonData[]) => {
      }, // success path
      error: (error: any) => console.error("Response Error: " + error),
    });
  }
}
